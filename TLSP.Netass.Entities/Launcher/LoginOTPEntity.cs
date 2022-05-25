
namespace TLSP.Netass.Entities
{
    [Serializable]
    public class LoginOTPEntity : EntityBase
    {

        [JsonPropertyName("otp")]
        public int OTPCode { get; set; }

        [JsonPropertyName("otp_token")]
        public string OTPToken { get; set; }

        [JsonPropertyName("aid")]
        public uint AccountID { get; set; }

        [JsonPropertyName("lock_time")]
        public int LockTime { get; set; }
        [JsonPropertyName("open_otp")]
        public int OpenOTP { get; set; }
    }
}
