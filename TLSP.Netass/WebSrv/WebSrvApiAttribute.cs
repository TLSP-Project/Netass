
namespace TLSP.Netass.WebSrv
{
    [AttributeUsage(AttributeTargets.Field |AttributeTargets.Class)]

    public class WebSrvApiAttribute  : Attribute
    {
        public string ApiRes { get;  }

        public Method Method { get; }

        public EncryptionType EncryptionType { get; }

        public bool LockToken { get; }

        public WebSrvApiAttribute(string res ,Method method =Method.Post, EncryptionType encryptionType = EncryptionType.NoEncryption,bool lockToken = true)
        {
            ApiRes = res;
            Method = method;
            EncryptionType = encryptionType;
            LockToken = lockToken;
        }
        public WebSrvApiAttribute()
        {
        }
    }


    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Delegate)]

    public class WebSrvApiBaseAttribute : Attribute
    {
        public bool IsList { get; }
        public WebSrvApiBaseAttribute()
        {

        }
        public WebSrvApiBaseAttribute(bool isList)
        {
            IsList = isList;
        }
    }


}
