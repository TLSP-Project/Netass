

namespace TLSP.Netass.WebSrv
{
    [WebSrvApi]
    public class ItemChannelContainer
    {
        [WebSrvApi("/item-channel/query/search-by-item-channel")]
        public PostEntityListDelegate<ItemChannelEntity, SearchByItemChannelRequest> QueryByChannel;

        [WebSrvApi("/item-channel/query/search-by-item")]
        public PostEntityListDelegate<ItemChannelEntity, SearchListByItemIDRequest> QueryByItemID;

        [WebSrvApi("/item-channel/query/search-item-channel-list-by-id")]
        public PostEntityListDelegate<ItemChannelEntity, SearchChannelByItemIDListRequest> QueryByIDList;


    }
}
