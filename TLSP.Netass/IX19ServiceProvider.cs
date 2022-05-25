using System;
using System.Collections.Generic;
using System.Text;
using TLSP.Common.Concurrent;

namespace TLSP.Netass
{
    public interface IX19ServiceProvider
    {

        byte[] HttpEncrypt(string res, string body);

        string HttpDecrypt(byte[] enData);

        string ParseLoginResponse(byte[] enData);

        string ComputeDynamicToken(string res, string body);

        string GetH5Token();
        
        void Logout();

        public AuthEntityLocker AuthEntity { get; }

        public WebSrvProvider WebSrvProvider { get; }
    }
}
