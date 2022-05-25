
namespace TLSP.Netass.Utilities
{
    public static class X19ServerHelper
    {
        [Serializable]
        public class ServerURLConfig
        {
            public string NewsVideo { get; set; }

            public string GameCenter { get; set; }

            public string ComponentCenter { get; set; }

            public string GameDetail { get; set; }

            public string CompDetail { get; set; }

            public string EmbedWebPageUrl { get; set; }

            public string VideoPrefix { get; set; }

            public string NewsVideoUrl { get; set; }

            public string GameCenterUrl { get; set; }

            public string ComponentCenterUrl { get; set; }

            public string GameDetailUrl { get; set; }

            public string CompDetailUrl { get; set; }

            public string VideoMediaUrl { get; set; }

            public string SeadraUrl { get; set; }

            public string AuthorityUrl { get; set; }

            public string CdnUrl { get; set; }

            public string ForumUrl { get; set; }

            public string ChatServerUrl { get; set; }

            public string WebServerUrl { get; set; }

            public string BackupWebServerUrl { get; set; }

            public string WebServerGrayUrl { get; set; }

            public string AuthServerUrl { get; set; }

            public string AuthServerCppUrl { get; set; }

            public string TransferServerUrl { get; set; }

            public string TransferServerHttpUrl { get; set; }

            public string StaticWebVersionUrl { get; set; }

            public string LiveHomePage { get; set; }

            public string VideoPlayerWebUrl { get; set; }

            public string ServerStop { get; set; }

            public string MgbSdkUrl { get; set; }

            public string CoreServerUrl { get; set; }

            public string ApiGatewayUrl { get; set; }

            public string DCWebUrl { get; set; }

            public string PeTransferServerUrl { get; set; }

            public string PeTransferServerHttpUrl { get; set; }

            public string PeTransferServerNewHttpUrl { get; set; }

            public int TempServerStop { get; set; } = 0;

            public int ServerHostNum { get; set; } = 0;

            public string MomentHomePageUrl { get; set; }

            public string HomePageUrl { get; set; }

            public string PlatformUrl { get; set; }

            public string VipCenterUrl { get; set; }

            public string SignCenterUrl { get; set; }

            public string ComponentAllStockUrl { get; set; }

            public List<Address> ChatServerList { get; set; }

            public List<Address> TransferServerList { get; set; }

            public List<Address> AuthServerList { get; set; }

            public string PathNUrl { get; set; }

            public string PePathNUrl { get; set; }

            public List<PeServerAddress> TransferPEServerList { get; set; }
            [Serializable]
            public class Address
            {
                public string IP { get; set; }

                public int Port { get; set; }

                public int Isp_Enabled { get; set; }

                public int Status { get; set; }
            }
            [Serializable]
            public class PeServerAddress
            {
                public int id { get; set; }

                public int status { get; set; }

                public string ip { get; set; }

                public int Isp_Enabled { get; set; }

                public List<int> ports { get; set; }
            }
        }
        [Serializable]
        public class WPFVersionInfo
        {
            public long Size { get; set; }
            public string URL { get; set; }
            public string MD5 { get; set; }

        }

        public static (string versionStr, Version version, WPFVersionInfo info) NewestWPFVersion { get; private set; }

        public static ServerURLConfig ServerConfig { get; private set; }

        public static async Task InitServerList()
        {
            RestResponse? response = null;


            using (var client = new RestClient("https://x19.update.netease.com"))
            {
                var request = new RestRequest("/pl/x19_java_patchlist", Method.Get);
                response = await client.ExecuteAsync(request);
                var versions = JsonSerializer.Deserialize<Dictionary<string, WPFVersionInfo>>("{" + response.Content + "}", new JsonSerializerOptions()
                {
                    AllowTrailingCommas = true,
                    PropertyNameCaseInsensitive = true
                });
                var versionList = versions.ToList();

                NewestWPFVersion = (versionList[versionList.Count - 1].Key, new Version(versionList[versionList.Count - 1].Key), versionList[versionList.Count - 1].Value);

                request = new RestRequest("/serverlist/release.json", Method.Get);
  

                ServerConfig = (await client.ExecuteAsync<ServerURLConfig>(request)).Data;
            }
            if (!string.IsNullOrEmpty(ServerConfig.ApiGatewayUrl))
            {
                ServerConfig.WebServerUrl = ServerConfig.ApiGatewayUrl;
            }

            #region PathURL

            //string isp = null;
            //try
            //{


            //    using (var client = new RestClient("https://whoami.nie.netease.com"))
            //    {
            //        var request = new RestRequest("/v2", Method.Get);
            //        request.AddHeader("X-AUTH-PRODUCT", "x19");
            //        request.AddHeader("X-AUTH-TOKEN", "token.WvXi0qCOVl31");

            //        response = await client.ExecuteAsync(request);


            //    }
            //    logger.Info("ISPResponse:{response}", response.Content);
            //    using (var document = JsonDocument.Parse(response.Content))
            //    {
            //        using (var info = JsonDocument.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(document.RootElement.GetProperty("payload").GetString()))))
            //        {
            //            logger.Info("ISPinfo:{@info}", info);
            //            switch (info.RootElement.GetProperty("isp").GetProperty("id").GetInt32())
            //            {
            //                case 10000:
            //                    isp = "ctcc";
            //                    break;
            //                case 10010:
            //                    isp = "cucc";
            //                    break;
            //                case 10086:
            //                    isp = "cmcc";
            //                    break;
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    logger.Warn(ex, "获取ISP时出错 Response:{@response}", response);
            //}
            //logger.Info("SwitchISP:{isp}", isp);
            //ServerConfig.PathNUrl = isp != null ? ServerConfig.PathNUrl.Replace("{isp}", isp) : null;

            //ServerConfig.PePathNUrl = isp != null ? ServerConfig.PePathNUrl.Replace("{isp}", isp) : null;

            #endregion


            #region H5Url

            //try
            //{
            //    using (var client = new RestClient(ServerConfig.StaticWebVersionUrl))
            //    {
            //        var request = new RestRequest("", Method.Get);
            //        response = await client.ExecuteAsync(request);
            //    }
            //    using (var document = JsonDocument.Parse(response.Content))
            //    {
            //        string @base = ServerConfig.EmbedWebPageUrl + document.RootElement.GetProperty("StaticWebVersion").GetString();
            //        logger.Info("H5UrlBase:" + @base);
            //        ServerConfig.NewsVideoUrl = @base + ServerConfig.NewsVideo;
            //        ServerConfig.CompDetailUrl = @base + ServerConfig.CompDetail;
            //        ServerConfig.ComponentCenterUrl = @base + ServerConfig.ComponentCenter;
            //        ServerConfig.GameCenterUrl = @base + ServerConfig.GameCenter;
            //        ServerConfig.GameDetailUrl = @base + ServerConfig.GameDetail;
            //        ServerConfig.VideoMediaUrl = @base + ServerConfig.VideoPrefix;
            //        ServerConfig.LiveHomePage = @base + "/#/live-center/homepage";
            //        ServerConfig.MomentHomePageUrl = @base + "/#/moment-center/homepage";
            //        ServerConfig.HomePageUrl = @base + "/#/moment-center/user-homepage/";
            //        ServerConfig.VipCenterUrl = @base + "/#/vip-center/homepage";
            //        ServerConfig.ComponentAllStockUrl = @base + "/#/component-center/all-stock";
            //        ServerConfig.SignCenterUrl = @base + "/#/sign-center/homepage";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    logger.Warn(ex, "获取H5 URL时出错 Response:{@response}", response);

            //}
            #endregion




            //ServerConfig.TransferServerList = ParseServerList(ServerConfig.TransferServerUrl);

            //foreach (var address in ServerConfig.TransferServerList)
            //{
            //    if (address.Status != 1)
            //        ServerConfig.TransferServerList.Remove(address);

            //}
            //using (var client = new RestClient(ServerConfig.PeTransferServerUrl))
            //{
            //    var request = new RestRequest("", Method.Get);


            //    var peServerList = await client.ExecuteAsync<List<ServerURLConfig.PeServerAddress>>(request);

            //    ServerConfig.TransferPEServerList = peServerList.Data ?? new List<ServerURLConfig.PeServerAddress>();
            //}




            //ServerConfig.ChatServerList = ParseServerList(ServerConfig.ChatServerUrl);

            ServerConfig.AuthServerList = ParseServerList(ServerConfig.AuthServerUrl);



            if (ServerConfig == null)
                throw new X19ServerExcepetion("获取Netease服务器列表失败！");

            if (!string.IsNullOrEmpty(ServerConfig.ServerStop) && ServerConfig.ServerStop.Equals("1"))
                throw new X19ServerExcepetion("Netease服务器正在停服维护！");

            if (string.IsNullOrEmpty(ServerConfig.WebServerUrl))
                throw new X19ServerExcepetion("获取Netease主服务器url失败！");

            if (ServerConfig.TempServerStop == 1)
                throw new X19ServerExcepetion("纪念4月4日全国哀悼日，停服！");

            if (ServerConfig.AuthServerList.Count == 0)
                throw new X19ServerExcepetion("获取Netease验证服务器url失败！");
        }

        


        private static List<ServerURLConfig.Address> ParseServerList(string url)
        {
            using (var client = new RestClient(url))
            {
                var request = new RestRequest("", Method.Get);
                var response = client.ExecuteAsync<List<ServerURLConfig.Address>>(request);
                response.Wait();
                return response.Result.Data ?? new List<ServerURLConfig.Address>();
            }
        }

    }
}
