

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class ItemSecondaryTypeEntity : EntityBase
    {

        [JsonPropertyName("master_type_id")]
        public EItemMasterType MasterType { get; set; }

        [JsonPropertyName("name")]
        public string SecondaryType { get; set; }

    }
}
