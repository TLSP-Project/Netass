
namespace TLSP.Netass.WebSrv
{
    [WebSrvApi]
    public class SkinContainer
    {

        [WebSrvApi("/user-game-skin/query/search-by-type")]
        public PostEntityListDelegate<GameTextureEntity, QueryGameSkinRequest> QuerySkin;

        [WebSrvApi("/user-game-skin-multi")]
        public PostEntityListDelegate<GameTextureEntity, GameSkinSettingsRequest> SetSkinSettings;

    }
}
