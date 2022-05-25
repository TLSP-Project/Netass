
namespace TLSP.Netass.Entities
{
    [Serializable]
    public class AuthenticationEntity : EntityBase
    {

        [JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("sead")]
        public string Sead { get; set; }

        [JsonPropertyName("lock_time")]
        public int LockTime { get; set; }

        [JsonPropertyName("hasMessage")]
        public bool HasMessage { get; set; }

        [JsonPropertyName("aid")]
        public uint AccountID { get; set; }

        [JsonPropertyName("sdkuid")]
        public string SDKUID { get; set; }

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("unisdk_login_json")]
        public string UniSDKLoginJsonBase64 { get; set; }

        [JsonPropertyName("verify_status")]
        public EVerfyStatus VerfyStatus { get; set; }

        [JsonPropertyName("hasGmail")]
        public bool HasGmail { get; set; }

        [JsonPropertyName("is_register")]
        public bool IsRegister { get; set; }

        [JsonPropertyName("env")]
        public string Env { get; set; }

        [JsonPropertyName("min_engine_version")]
        public string MinEngineVersion { get; set; }

        [JsonPropertyName("min_patch_version")]
        public string MinPatchVersion { get; set; }

    }

    public enum EVerfyStatus
    {
        Unknow,
        Unknow2,
        Success,
        NeedRealName 
    }
}
