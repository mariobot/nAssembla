using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace nAssembla.DTO
{
    /*{"error":"invalid_grant",
     * "error_description":"The provided access grant is invalid, expired, or revoked (e.g. invalid assertion, expired authorization token, bad end-user password credentials, or mismatching authorization code and redirection URI)."}*/
    public class Error
    {
        [JsonProperty("error")]
        public string ErrorType { get; set; }
        [JsonProperty("error_description")]
        public string Description { get; set; }
    }
}
