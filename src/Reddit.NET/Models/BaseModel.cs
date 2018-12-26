﻿using Reddit.Models.Internal;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Reddit.Models
{
    public abstract class BaseModel : Request
    {
        internal override string AppId { get; set; }
        internal override string AccessToken { get; set; }
        internal override string RefreshToken { get; set; }
        internal override string DeviceId { get; set; }

        internal override List<DateTime> Requests { get; set; }

        public BaseModel(string appId, string refreshToken, string accessToken, ref RestClient restClient, string deviceId = null)
            : base(appId, refreshToken, accessToken, ref restClient, deviceId) { }

        public string Sr(string subreddit)
        {
            return (!string.IsNullOrWhiteSpace(subreddit) ? "/r/" + subreddit + "/" : "");
        }
    }
}
