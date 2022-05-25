

namespace TLSP.Netass.WebSrv
{

    [Serializable]
    public class WebSrvResponse<EntityType> : ResponseBase
    {
        [JsonPropertyName("entity")]
        public EntityType Entity { get; set; }

    }
}
