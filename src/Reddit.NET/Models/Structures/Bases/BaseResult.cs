﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Reddit.Models.Structures
{
    [Serializable]
    public abstract class BaseResult
    {
        [JsonProperty("errors")]
        public List<List<string>> Errors;

        [JsonProperty("ratelimit")]
        public double Ratelimit;
    }
}
