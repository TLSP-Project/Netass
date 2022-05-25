
namespace TLSP.Netass.WebSrv
{
    public class WebSrvApiException : Exception
    {
        public string Resource { get; }

        public string? Content { get;  }

        public string RequestParamas { get; }

        public ResponseBase? Response { get;}

        public WebSrvApiException(string msg, string res, string requestParamas, string? content, ResponseBase? responseData = null): base(msg)
        {
            Resource = res;

            RequestParamas = requestParamas;

            Content = content;

            Response = responseData;

        }
        public WebSrvApiException(Exception ex,string msg, string res, string requestParamas, string? content, ResponseBase? responseData = null) : base(msg,ex)
        {
            Resource = res;

            RequestParamas = requestParamas;

            Content = content;

            Response = responseData;

        }


    }
}
