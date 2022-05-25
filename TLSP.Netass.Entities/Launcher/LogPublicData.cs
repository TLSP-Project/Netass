
namespace TLSP.Netass.Entities
{
    public class LogPublicData
    {
        [JsonPropertyName("os_name")]
        public string OSName { get; set; } = "windows";

        [JsonPropertyName("os_ver")]
        public string OSVer { get; set; } = "Microsoft Windows 10";

        [JsonPropertyName("mac_addr")]
        public string MACAddress { get; set; }

        [JsonPropertyName("udid")]
        public string UDID { get; set; }

        [JsonPropertyName("app_ver")]
        public string APPVersion { get; set; }

        [JsonPropertyName("sdk_ver")]
        public string SDKVersion { get; set; } = string.Empty;

        [JsonPropertyName("network")]
        public string Network { get; set; } = string.Empty;

        [JsonPropertyName("disk")]
        public string Disk { get; set; }

        [JsonPropertyName("is64bit")]
        public string Is64bit { get; set; } = "1";

        [JsonPropertyName("video_card1")]
        public string VideoCard1 { get; set; } = "NVIDIA GeForce GTX 1060";

        [JsonPropertyName("video_card2")]
        public string VideoCard2 { get; set; } =string.Empty;

        [JsonPropertyName("video_card3")]
        public string VideoCard3 { get; set; } = string.Empty;

        [JsonPropertyName("video_card4")]
        public string VideoCard4 { get; set; } = string.Empty;

        [JsonPropertyName("launcher_type")]
        public string LauncherType { get; set; } = "PC_java";

        [JsonPropertyName("pay_channel")]
        public string PayChannel { get; set; } = "netease";

        public LogPublicData(string mac,string udid,string appVer,string disk)
        {
            MACAddress = mac;
            UDID = udid;
            APPVersion = appVer;
            Disk = disk;
        }
    }
}
