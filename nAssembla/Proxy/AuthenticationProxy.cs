using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nAssembla.Proxy
{
    public class AuthenticationProxy : ProxyReadOnlyBase<DTO.Authentication>
    {
        private int pinCode = 0;
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { "token" };
            }
        }

        public static Uri PinAuthorizationUrl
        {
            get
            {
                if (string.IsNullOrEmpty(Configuration.ClientId) || string.IsNullOrEmpty(Configuration.ClientSecret))
                    throw new Exception("'ClientId' and 'ClientSecret' must be specified in configuration when trying to authenticate via the PIN method");

                return new Uri(System.IO.Path.Combine(Configuration.BaseApiUrl,
                    string.Format("authorization?client_id={0}&response_type=pin_code", nAssembla.Configuration.ClientId)
                    ));
            }
        }

        public async Task<bool> AuthenticateWithPin(int pin)
        {
            pinCode = pin;
            var data = await SendRequestWithBodyAsync(default(DTO.Authentication), "POST");

            //Set authentication data
            Configuration.AccessToken = data.AccessToken;

            return true;
        }

        protected override Uri GetRequestUri()
        {
            var url = System.IO.Path.Combine(Configuration.BaseApiUrl, "token?grant_type=pin_code&pin_code=" + pinCode);
            return new Uri(url, UriKind.Absolute);
        }       

    }
}
