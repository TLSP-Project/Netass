
namespace TLSP.Netass.WebSrv
{
    [WebSrvApi]
    public class GameCharacterContainer
    {
        [WebSrvApi("/game-character/query/user-game-characters")]
        public PostEntityListDelegate<RoleEntity, QueryRoleListRequest> QueryCharacterList;


        [WebSrvApi("/game-character/query/search-by-character")]
        public PostEntityListDelegate<RoleEntity, SearchByCharacterRequest> QueryByCharacter;

        [WebSrvApi("/game-character")]
        public PostEntityDelegate<RoleEntity, AddRoleRequest> AddCharacter;

        [WebSrvApi("/game-character/delete")]
        public PostEntityDelegate<RoleEntity, EntityIDRequest> DeleteCharacter;

        [WebSrvApi("/game-character/pre-delete")]
        public PostEntityDelegate<RoleEntity, EntityIDRequest> PreDeleteCharacter;

        [WebSrvApi("/game-character/cancel-pre-delete")]
        public PostEntityDelegate<RoleEntity, EntityIDRequest> CancelPreDeleteCharacter;
    }
}
