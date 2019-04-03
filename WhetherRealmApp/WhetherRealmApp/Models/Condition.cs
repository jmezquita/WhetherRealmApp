using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WhetherRealmApp.Models
{
    public partial class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        public string IconUrl
        {
            get
            {
                return $"http:{Icon}";
            }
        }
    }
}
