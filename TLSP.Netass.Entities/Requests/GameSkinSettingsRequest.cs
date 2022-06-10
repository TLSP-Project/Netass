

namespace TLSP.Netass.Entities
{
    public class GameSkinSettingsRequest
    {
        [JsonPropertyName("skin_settings")]

        public IEnumerable<GameTextureEntity> Settings { get; set; }


        public static implicit operator GameSkinSettingsRequest(List<GameTextureEntity> settings) => new GameSkinSettingsRequest { Settings = settings };

}
}
