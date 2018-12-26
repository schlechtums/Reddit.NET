﻿using Newtonsoft.Json;
using System;

namespace Reddit.Models.Structures
{
    [Serializable]
    public class PostChild : BaseContainer
    {
        [JsonProperty("data")]
        public Post Data;
    }
}
