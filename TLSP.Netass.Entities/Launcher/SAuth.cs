

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class SAuth
    {


        [JsonPropertyName("gameid")]
        public string GameID { get; set; } = "x19";
        [JsonPropertyName("login_channel")]
        public string LoginChannel { get; set; } = "netease";

        [JsonPropertyName("app_channel")]
        public string AppChannel { get; set; } = "netease";

        [JsonPropertyName("platform")]
        public string Platform { get; set; } = "pc";

        [JsonPropertyName("sdkuid")]
        public string SDKUserID { get; set; }

        [JsonPropertyName("sessionid")]
        public string SessionID { get; set; }
        [JsonPropertyName("sdk_version")]
        public string SDKVersion { get; set; } = "3.4.0";
        [JsonPropertyName("udid")]
        public string UDID { get; set; }

        [JsonPropertyName("deviceid")]
        public string DeviceID { get; set; }

        [JsonPropertyName("aim_info")]
        public string AimInfo { get { return "{\"aim\":\"" + IP + "\",\"country\":\"CN\",\"tz\":\"+0800\",\"tzid\":\"\"}"; } set { } }

        [JsonPropertyName("client_login_sn")]
        public string ClientLoginSign { get; set; } = Guid.NewGuid().ToString("N").ToUpperInvariant();
        [JsonPropertyName("gas_token")]
        public string GasToken { get; set; } = "";
        [JsonPropertyName("source_platform")]
        public string SourcePlatform { get; set; } = "pc";

        [JsonPropertyName("ip")]
        public string IP { get; set; }

    }

}
