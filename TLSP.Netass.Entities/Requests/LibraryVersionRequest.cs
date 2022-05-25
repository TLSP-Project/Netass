
namespace TLSP.Netass.Entities
{
    public class LibraryVersionRequest
    {
        [JsonPropertyName("library_version")]
        public ulong Version { get; set; }

        public LibraryVersionRequest(ulong version)
        {
            Version = version;
        }
    }
}
