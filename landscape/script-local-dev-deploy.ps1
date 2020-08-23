## Requirements 
## Powershell core (6+)
## Azure powershell v 4.5+

## Run Connect-AzAccount
## Set Az Context (Set-AzContext <subscription-id>)

## Set $TemplateStorageAccountName = 'st******'
## Set $TemplateStorageContainerName = '*****'
## Set $TemplatStorageAccountResourceGroup = 'rg-***-devops'
## Set $ResourceNameInfix = '****'

$EnvironmentSuffix = 'dev'
$LocationSuffix = 'euw'
$ResourceNameSuffix = $EnvironmentSuffix + '-' + $LocationSuffix

$Guid = [guid]::NewGuid().guid

$ResourceGroup = 'rg-' + $ResourceNameInfix + '-' + $ResourceNameSuffix
$StorageLocation = 'https://' + $TemplateStorageAccountName + '.blob.core.windows.net/' + $TemplateStorageContainerName + '/temp/' 

## Create temp SasToken
$StorageAccountKey = (Get-AzStorageAccountKey -ResourceGroupName $TemplatStorageAccountResourceGroup -AccountName $TemplateStorageAccountName).Value[0]
$StorageContext = New-AzStorageContext -StorageAccountName $TemplateStorageAccountName -StorageAccountKey $StorageAccountKey
$StartTime = Get-Date
$EndTime = $startTime.AddMinutes(15)
$StorageSasToken = New-AzStorageContainerSASToken -Name $TemplateStorageContainerName -Permission rwdl -StartTime $StartTime -ExpiryTime $EndTime -context $StorageContext

## Upload templates

## copy templates to local temp dir
$LocalTempDir = 'C:\temp\'
$LocalTempTemplatesDir = $LocalTempDir + $Guid 

New-Item -ItemType Directory -Force -Path $LocalTempTemplatesDir | Out-null

Get-ChildItem ((Get-Location).Path + '\landscape\') -Recurse -Include *.json | ForEach-Object { Join-Path -Path $_.Directory -ChildPath $_.Name } | Copy-Item -Destination "$LocalTempTemplatesDir"

#fill in parameter template file
$TemplateParameterFile = '/azuredeploy.parameters.' + $EnvironmentSuffix + '.json'

$TemplateFileText = [System.IO.File]::ReadAllText($LocalTempTemplatesDir + $TemplateParameterFile )
$TemplateObject = ConvertFrom-Json $TemplateFileText -AsHashtable
$TemplateObject.parameters.resourceName.value = @{ infix = $ResourceNameInfix; suffix = $ResourceNameSuffix }
$TemplateObject.parameters.templatesStorage.value = @{ location = $StorageLocation + $Guid; sasToken = $StorageSasToken }
$TemplateFileText = $TemplateObject | ConvertTo-Json -Depth 100
[System.IO.File]::WriteAllText($LocalTempTemplatesDir + $TemplateParameterFile, $TemplateFileText)

## copy templates from local temp dir to azure storage
foreach ($item in Get-ChildItem -Path $LocalTempTemplatesDir -File -Recurse -Include "*.json" ) {
    "Uploading $LocalTempTemplatesDir\$($item.Name) to temp/$Guid/$($item.Name)"
    Set-AzStorageBlobContent `
        -Container $TemplateStorageContainerName `
        -Context $StorageContext  `
        -File ("$LocalTempTemplatesDir\" + $item.Name ) `
        -Blob ("temp/" + $Guid + "/" + $item.Name) `
        -Force | Out-null
}

## execute what if
$AzureDeployTemplateUri = $StorageLocation + $Guid + '/azuredeploy.json' + $StorageSasToken
$AzureDeployParameterUri = $StorageLocation + $Guid + $TemplateParameterFile + $StorageSasToken

Test-AzResourceGroupDeployment `
    -Mode Complete `
    -ResourceGroupName $ResourceGroup `
    -TemplateUri $AzureDeployTemplateUri `
    -TemplateParameterUri $AzureDeployParameterUri

New-AzResourceGroupDeployment `
    -Mode Complete `
    -ResourceGroupName $ResourceGroup `
    -TemplateUri $AzureDeployTemplateUri `
    -TemplateParameterUri $AzureDeployParameterUri `
    # -WhatIf 

# Cleanup temp storage
$BlobsToDelete = 'temp/' + $Guid + '/*'
Get-AzStorageBlob -Container $TemplateStorageContainerName -Blob $BlobsToDelete -Context $StorageContext | Remove-AzStorageBlob
 
Remove-Item $LocalTempTemplatesDir -Force -Recurse