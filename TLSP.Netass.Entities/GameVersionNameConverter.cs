

using System.Linq;
using System.Text.Json;

namespace TLSP.Netass.Entities
{
    public class GameVersionNameConverter : JsonConverter<EGameVersion>
    {
        public override EGameVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => VersionNameDic[reader.GetString()];

		public override void Write(Utf8JsonWriter writer, EGameVersion value, JsonSerializerOptions options) => writer.WriteStringValue(VersionNameDic.First(t=> t.Value == value).Key);



		public static readonly Dictionary<string, EGameVersion> VersionNameDic = new Dictionary<string, EGameVersion>
		{
			{
				"",
				EGameVersion.NONE
			},
			{
				"100.0.0",
				EGameVersion.V_CPP
			},
			{
				"200.0.0",
				EGameVersion.V_RTX
			},
			{
				"1.7.10",
				EGameVersion.V_1_7_10
			},
			{
				"1.10.2",
				EGameVersion.V_1_10_2
			},
			{
				"1.8",
				EGameVersion.V_1_8
			},
			{
				"1.11.2",
				EGameVersion.V_1_11_2
			},
			{
				"1.8.8",
				EGameVersion.V_1_8_8
			},
			{
				"1.8.9",
				EGameVersion.V_1_8_9
			},
			{
				"1.9.4",
				EGameVersion.V_1_9_4
			},
			{
				"1.6.4",
				EGameVersion.V_1_6_4
			},
			{
				"1.7.2",
				EGameVersion.V_1_7_2
			},
			{
				"1.12",
				EGameVersion.V_1_12
			},
			{
				"1.12.2",
				EGameVersion.V_1_12_2
			},
			{
				"1.13.2",
				EGameVersion.V_1_13_2
			},
			{
				"1.14.3",
				EGameVersion.V_1_14_3
			},
			{
				"1.15",
				EGameVersion.V_1_15
			},
			{
				"1.16",
				EGameVersion.V_1_16
			},
			{
				"1.18",
				EGameVersion.V_1_18
			}
		};



	}
}
