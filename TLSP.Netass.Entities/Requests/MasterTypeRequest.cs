
namespace TLSP.Netass.Entities
{
    [Serializable]
    public class MasterTypeRequest
    {
        [JsonPropertyName("master_type_id")]
        EItemMasterType MasterType { get; set; }

        public MasterTypeRequest(EItemMasterType masterType)
        {
            MasterType = masterType;
        }
    }
}
