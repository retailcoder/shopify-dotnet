﻿namespace Shopify.Api.Models
{
    #region Namespace

    using Newtonsoft.Json;
    using System.Collections.Generic;

    #endregion

    public sealed class Webhook
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("topic")]
        public string Topic { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
        [JsonProperty("fields")]
        public List<object> Fields { get; set; }
        [JsonProperty("metafield_namespaces")]
        public List<object> MetafieldNamespaces { get; set; }
    }
}