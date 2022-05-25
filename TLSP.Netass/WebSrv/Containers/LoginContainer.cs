

namespace TLSP.Netass.WebSrv
{





    [WebSrvApi]
    public class LoginContainer
    {

        [WebSrvApi("/authentication-otp", Method.Post, EncryptionType.LoginEncryption, false)]


        public PostEntityDelegate<AuthenticationEntity, AuthenticationOTPRequest> AuthenticationOTP;




        [WebSrvApi("/authentication/update", Method.Post, EncryptionType.LoginEncryption,false)]


        public PostEntityDelegate<AuthenticationEntity, AuthenticationUpdateRequest> AuthenticationUpdate;



        [WebSrvApi("/login-otp")]
        public PostEntityDelegate<LoginOTPEntity, LoginOTPRequest> LoginOTP;
    }


}
