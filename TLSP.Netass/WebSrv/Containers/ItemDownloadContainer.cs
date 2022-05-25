

namespace TLSP.Netass.WebSrv
{
    [WebSrvApi]
    public class ItemDownloadContainer
    {
        [WebSrvApi("/user-item-download-v2")]
        public PostEntityDelegate<ItemDownloadEntity, ItemIDRequest> GetDownloadInfo;

        [WebSrvApi("/user-item-download-v2/get-list")]
        public PostEntityListDelegate<ItemDownloadEntity, ItemIDListRequest> GetDownloadInfoList;
    }
}

