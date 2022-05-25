
using System.Linq;
using System.Text.Json;

namespace TLSP.Netass.Entities
{
    public class GameVersionIDNumConverter : GameVersionIDConverter
    {
        public override void Write(Utf8JsonWriter writer, EGameVersion value, JsonSerializerOptions options) => writer.WriteNumberValue(int.Parse(VersionIDDic.First(t => t.Value == value).Key));
    }
}
