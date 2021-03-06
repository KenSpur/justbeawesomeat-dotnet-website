﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Application.Shared.ContactPage
{
    public class ContactPageData : IPageData
    {
        [JsonPropertyName("info")]
        public ICollection<Info> Info { get; set; } = new List<Info>();
    }
}