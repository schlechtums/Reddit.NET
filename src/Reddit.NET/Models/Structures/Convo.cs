﻿using Newtonsoft.Json;
using Reddit.Models.Converters;
using System;

namespace Reddit.Models.Structures
{
    [Serializable]
    public class Convo
    {
        [JsonProperty("date")]
        [JsonConverter(typeof(TimestampConvert))]
        public DateTime Date;

        [JsonProperty("permalink")]
        public string Permalink;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("subject")]
        public string Subject;
    }
}
