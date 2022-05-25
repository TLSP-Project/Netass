

using System.Text.Json;

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class AuthenticationOTPRequest
    {
        [Serializable]
        public class VersionEntity
        {
            [JsonPropertyName("version")]
            public string Version { get; set; }

            [JsonPropertyName("launcher_md5")]
            public string LauncherMD5 { get; set; } = string.Empty;

            [JsonPropertyName("updater_md5")]
            public string UpdaterMD5 { get; set; } = string.Empty;

            public VersionEntity(string version)
            {
                Version = version;
            }
        }

        [JsonPropertyName("otp_token")]
        public string OTPToken { get; set; }

        [JsonPropertyName("otp_pwd")]
        public string OTPPassWord { get; set; } = string.Empty;

        [JsonPropertyName("aid")]
        public uint AccountID { get; set; }

        [JsonPropertyName("sauth_json")]
        public string AuthData { get; set; }

        [JsonPropertyName("sa_data")]
        public string LogData { get; set; }

        [JsonPropertyName("version")]
        public VersionEntity LauncherVersion { get; set; }


        public AuthenticationOTPRequest(string launcherVersion, LogPublicData publicData, SAuth sAuth, uint account, string otpToken)
        {
            LauncherVersion = new VersionEntity(launcherVersion);
            LogData = JsonSerializer.Serialize(publicData);
            AuthData = JsonSerializer.Serialize(sAuth);
            AccountID = account;
            OTPToken = otpToken;
        }
    }

}
