

namespace TLSP.Netass.Entities
{
    public class ItemAvailableQueryRequest : SeachListRequest
    {
        [JsonPropertyName("item_type")]
        public EItemType ItemType { get; set; }
        [JsonPropertyName("master_type_id")]
        public EItemMasterType MasterType { get; set; }


        [JsonPropertyName("secondary_type_id")]
        public string? SecondaryType { get; set; }


        [JsonPropertyName("available_mc_versions")]
        public IEnumerable<EItemAvailableGameVerison>? AvailableMCVersions { get; set; }

    }
}
