

using System.Text.Json;

namespace TLSP.Netass.Entities
{

    [Serializable]
    public class LoginOTPRequest
    {
        [JsonPropertyName("sauth_json")]
        public string AuthData { get; set; }

        public LoginOTPRequest(SAuth sAuth)
        {
            AuthData = JsonSerializer.Serialize(sAuth);
        }
    }
}
