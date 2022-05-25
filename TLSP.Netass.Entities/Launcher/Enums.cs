

namespace TLSP.Netass.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Serializable]
    public enum EVipStatus
    {

        unknown,

        effected,

        expired
    }
}
