


namespace TLSP.Netass.WebSrv
{
    [WebSrvApi]
    public class GameLaunchContainer
    {
        [WebSrvApi("/item-address/get")]
        public PostEntityDelegate<ServerAddressEntity, ItemIDRequest> GetNetGameServerAddress;




        [WebSrvApi("/game-auth-item-list/query/search-by-game")]

        public PostEntityDelegate<AuthItemEntity, AuthItemRequest> GetAuthItemList;

        [WebSrvApi("/game-patch-info")]

        public PostEntityDelegate<GameClientPatchEntity, GameVersionRequest> GetClientPatchInfo;


        [WebSrvApi("/client-library-info/check-change", Method.Post, EncryptionType.NormalEncryption)]
        public PostEntityDelegate<LibStateEntity, LibraryVersionRequest> GetLibraryChange;

        [WebSrvApi("/client-library-info/search-by-mc-version", Method.Post, EncryptionType.NormalEncryption)]
        public PostEntityDelegate<CheckLibInfoEntity, GameVersionRequest> GetLibraryInfo;
    }
}
