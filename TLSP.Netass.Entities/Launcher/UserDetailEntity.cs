
namespace TLSP.Netass.Entities
{

    public class UserDetailEntity : EntityBase
    {
        [JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonPropertyName("aid")]
        public string AccountID{ get; set; }

        [JsonPropertyName("avatar_image_url")]
        public string AvatarImageUrl { get; set; }

        [JsonPropertyName("can_buy_first_charge_vip")]
        public bool CanBuyFirstChargeVip { get; set; }

        [JsonPropertyName("can_buy_vip_special")]
        public bool CanBuyVipSpecial { get; set; }

        [JsonPropertyName("cape_number")]
        public int CapeNumber { get; set; }

        [JsonPropertyName("frame_id")]
        public string FrameID { get; set; }

        [JsonPropertyName("freezed")]
        public int Freezed { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("head_image")]
        public string HeadImage { get; set; }

        [JsonPropertyName("head_image_cd")]
        public int HeadImageCD { get; set; }

        [JsonPropertyName("instruct_info")]
        public string InstructInfo { get; set; }

        [JsonPropertyName("isAntiAddiction")]
        public bool IsAntiAddiction { get; set; }

        [JsonPropertyName("is_subscribe")]
        public bool IsSubscribe { get; set; }

        [JsonPropertyName("is_vip")]
        public bool IsVip { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("login_time")]
        public int LoginTime { get; set; }

        [JsonPropertyName("logout_time")]
        public int LogoutTime { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("need_realname_auth")]
        public bool NeedRealnameAuth { get; set; }

        [JsonPropertyName("nickname_free")]
        public int NicknameFree { get; set; }

        [JsonPropertyName("nickname_init")]
        public int NicknameInit { get; set; }

        [JsonPropertyName("realname_status")]
        public int RealnameStatus { get; set; }

        [JsonPropertyName("register_time")]
        public int RegisterTime { get; set; }

        [JsonPropertyName("rest_currency_time")]
        public int RestCurrencyTime { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("signature")]
        public string Signature { get; set; }

        [JsonPropertyName("skin_number")]
        public int SkinNumber { get; set; }

        [JsonPropertyName("subscribe_expiration_time")]
        public int SubscribeExpirationTime { get; set; }

        [JsonPropertyName("vip_info")]
        public VipInfo VipInfo { get; set; }
    }


    public class VipInfo
    {
        [JsonPropertyName("accumulative_total")]
        public int AccumulativeTotal { get; set; }

        [JsonPropertyName("begin_at")]
        public int BeginAt { get; set; }

        [JsonPropertyName("expired_at")]
        public int ExpiredAt { get; set; }

        [JsonPropertyName("status")]
        public EVipStatus Status { get; set; }
    }


}
