using System;
using System.Collections.Generic;
using System.Text;

namespace TLSP.Netass.Entities
{
    public class ServerAddressEntity : EntityBase
    {
        [JsonPropertyName("ip")]
        public string IP { get; set; }
        [JsonPropertyName("port")]
        public ushort Port { get; set; }
        [JsonPropertyName("game_status")]
        public int GameStatus { get; set; }
        [JsonPropertyName("announcement")]
        public string Announcement { get; set; }
        [JsonPropertyName("in_whitelist")]
        public bool IsInWhiteList { get; set; }
    }
}
