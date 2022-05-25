

namespace TLSP.Netass.WebSrv
{
    [WebSrvApi]
    public class ItemMCVersionContainer
    {
        [WebSrvApi("/item-mc-version/query/search-by-items")]
        public PostEntityListDelegate<MCVersionEntity, ItemIDsRequest> GetVersionListByItems;

        [WebSrvApi("/item-mc-version/query/search-by-item")]
        public PostEntityListDelegate<MCVersionEntity, SearchListByItemIDRequest> GetVersionListByItem;
    }
}
