﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Shared.Entities.API
{
    public class LossContainer
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Loss Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
