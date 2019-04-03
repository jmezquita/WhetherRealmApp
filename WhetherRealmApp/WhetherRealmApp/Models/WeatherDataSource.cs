using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WhetherRealmApp.Models
{
        public partial class WeatherDataSource
        {
            [JsonProperty("location")]
            public Location Location { get; set; }

            [JsonProperty("current")]
            public Current Current { get; set; }
        }
}
