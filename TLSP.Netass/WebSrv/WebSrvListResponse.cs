
namespace TLSP.Netass.WebSrv
{
    [Serializable]
    public class WebSrvListResponse<EntityType> : ResponseBase
    {

        [JsonPropertyName("entities")]
        public List<EntityType> Entities { get; set; }


        [JsonPropertyName("total")]
        public int TotalCount { get; set; }

    }
}
