using System.Linq;
using System.Text.Json;

namespace TLSP.Netass.Entities
{
    public class GameVersionIDConverter : JsonConverter<EGameVersion>
    {

		public override EGameVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => VersionIDDic[reader.GetString()];

		public override void Write(Utf8JsonWriter writer, EGameVersion value, JsonSerializerOptions options) => writer.WriteStringValue(VersionIDDic.First(t => t.Value == value).Key);






		public static readonly Dictionary<string, EGameVersion> VersionIDDic = new Dictionary<string, EGameVersion>
		{
			{
				"",
				EGameVersion.NONE
			},
			{
				"1",
				EGameVersion.V_1_7_10
			},
			{
				"2",
				EGameVersion.V_1_8
			},
			{
				"3",
				EGameVersion.V_1_9_4
			},
			{
				"5",
				EGameVersion.V_1_11_2
			},
			{
				"6",
				EGameVersion.V_1_8_8
			},
			{
				"7",
				EGameVersion.V_1_10_2
			},
			{
				"8",
				EGameVersion.V_1_6_4
			},
			{
				"9",
				EGameVersion.V_1_7_2
			},
			{
				"10",
				EGameVersion.V_1_12_2
			},
			{
				"11",
				EGameVersion.NONE
			},
			{
				"12",
				EGameVersion.V_1_8_9
			},
			{
				"13",
				EGameVersion.V_CPP
			},
			{
				"14",
				EGameVersion.V_1_13_2
			},
			{
				"15",
				EGameVersion.V_1_14_3
			},
			{
				"16",
				EGameVersion.V_1_15
			},
			{
				"17",
				EGameVersion.V_1_16
			},
			{
				"18",
				EGameVersion.V_RTX
			},
			{
				"19",
				EGameVersion.V_1_18
			}
		};



	}
}
