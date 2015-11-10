using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;

namespace nAssembla.Proxy
{
    public class CustomReportsProxy : ProxyReadOnlyBase<DTO.CustomReport>
    {
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "tickets", "custom_reports" };
            }
        }

        internal override bool DataIsCachable
        {
            get { return true; }
        }

        protected override async Task<IEnumerable<DTO.CustomReport>> GetListAsyncInternal()
        {
            var web = CreateWebRequest("GET");

            try
            {
                var response = await web.GetResponseAsync();

                var answer = new StreamReader(response.GetResponseStream());
                var json = answer.ReadToEnd();

                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO.CustomReports>(json);

                var ret = new List<DTO.CustomReport>();
                if (data != null)
                {
                    if (data.TeamReports != null)
                        ret.AddRange(data.TeamReports.Cast<DTO.CustomReport>());

                    if (data.UserReports != null)
                        ret.AddRange(data.UserReports.Cast<DTO.CustomReport>());
                }

                return ret;
            }
            catch (WebException ex)
            {
                throw;
            }
        }
        
    }
}