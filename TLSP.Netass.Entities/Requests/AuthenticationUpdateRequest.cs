

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class AuthenticationUpdateRequest
    {
        [JsonPropertyName("entity_id")]
        public uint AccountID { get; set; }


        public static implicit operator AuthenticationUpdateRequest(uint aid) => new AuthenticationUpdateRequest { AccountID = aid };
    }
}
