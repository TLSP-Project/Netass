

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class ItemIDListRequest
    {

        [JsonPropertyName("item_id_list")]
        public List<string> ItemIDList { get; set; }


        public static implicit operator ItemIDListRequest(List<string> list)
        {
            return new ItemIDListRequest { ItemIDList = list };
        }
    }
}
