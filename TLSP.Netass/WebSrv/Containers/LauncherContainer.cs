

namespace TLSP.Netass.WebSrv
{
    [WebSrvApi]
    public class LauncherContainer
    {
        [WebSrvApi("/user-detail")]
        public GetEntityDelegate<UserDetailEntity> GetUserDetail;

        [WebSrvApi("/server-time", Method.Get)]
        public GetEntityDelegate<ServerTimeEntity> GetServerTime;
    }
}
