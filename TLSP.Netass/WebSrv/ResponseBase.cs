
using System.Net;

namespace TLSP.Netass.WebSrv
{

    [Serializable]
    public class ResponseBase
    {
        [JsonPropertyName("code")]
        public int Code { get; set; } = -123456;

        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("details")]
        public string Details { get; set; }

    }
}
