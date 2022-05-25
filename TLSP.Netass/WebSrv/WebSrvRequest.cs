

namespace TLSP.Netass.WebSrv
{
    public enum EncryptionType
    {
        NoEncryption,
        NormalEncryption,
        LoginEncryption
    }

    public class WebSrvRequest : RestRequest
    {

        public EncryptionType NeedEncrypt { get; set; }

        public string KeyIn { get; set; }

        public string KeyOut { get; set; }

        public WebSrvRequest(string resource, Method method, EncryptionType encryptionType = EncryptionType.NoEncryption) : base(resource, method)
        {
            this.KeyIn = string.Empty;
            this.KeyOut = string.Empty;
            this.NeedEncrypt = encryptionType;
        }
    }
}
