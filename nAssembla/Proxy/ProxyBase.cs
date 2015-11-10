using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace nAssembla.Proxy
{
    public interface AssemblaProxy
    {

    }

    public abstract class ProxyReadOnlyBase<T> : AssemblaProxy
        where T : DTO.DTOReadOnlyBase, new()
    {
        #region Fields
        
        protected const string SpacesUriPath = "spaces";
        protected const string TicketNumberPath = "_ticket_number";
        private Dictionary<string, string> additionalUriQueryParameters = new Dictionary<string, string>();
        private readonly bool _isDataCachable = false;
        private bool _dataIsCached = false;
        private IList<T> _dataCache;
        
        #endregion

        #region Properties

        protected abstract string[] BaseUriParameters { get; }

        protected string[] AdditionalUriParameters { get; set; }

        internal virtual bool DataIsCachable { get { return _isDataCachable; } }

        internal IList<T> DataCache
        {
            get { return this._dataCache; }
            set
            {
                this._dataCache = value;
                _dataIsCached = true;
            }
        }

        protected Dictionary<string, string> AdditionalUriQueryParameters
        {
            get { return additionalUriQueryParameters; }
        }

        #endregion

        #region Methods        

        public async Task<IEnumerable<T>> GetListAsync(bool forceRefresh = false)
        {
            var data = default(IEnumerable<T>);
            if ((_dataIsCached && !forceRefresh) || (DataIsCachable && DataCache != null && !forceRefresh))
            {
                data = DataCache;
            }
            else
            {
                data = await GetListAsyncInternal();
                if (DataIsCachable && data != null)
                {
                    _dataIsCached = true;
                    DataCache = data.ToList();
                }
            }

            return data;
        }

        /// <summary>
        /// This is the implementation fo the actual retrieval of the data list. It is wrapped by <see cref="GetListAsync"/>, 
        /// which handles the data caching.
        /// </summary>
        /// <returns></returns>
        protected virtual async Task<IEnumerable<T>> GetListAsyncInternal()
        {
            return await GetAsync<IEnumerable<T>>();
        }

        /// <summary>
        /// Generates the actual HttpWebRequest. This method passes in authentication parameters
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        protected virtual HttpWebRequest CreateWebRequest(string method)
        {
            var uri = GetRequestUri();
            var web = (HttpWebRequest)HttpWebRequest.Create(uri);
            web.Method = method;

            web.Accept = "application/json";
            if (method != "GET")
                web.ContentType = "application/json";

            SetWebRequestAuthorization(web);

            return web;
        }

        protected virtual void SetWebRequestAuthorization(HttpWebRequest web)
        {
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                web.Headers["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            else if (!string.IsNullOrEmpty(Configuration.ClientId) && !string.IsNullOrEmpty(Configuration.ClientSecret))
            {
                //Basic auth
                var base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(Configuration.ClientId + ":" + Configuration.ClientSecret));
                web.Headers["Authorization"] = "Basic " + base64;
            }
            else
            {
                if (string.IsNullOrEmpty(Configuration.ApiKey) || string.IsNullOrEmpty(Configuration.ApiSecret))
                    throw new Exception("nAssembla must be authenticated against Assembla. This can be done via Api key/secret or client credentials. Neither are currently set.");

                web.Headers["X-Api-key"] = Configuration.ApiKey;
                web.Headers["X-Api-secret"] = Configuration.ApiSecret;
            }
        }

        protected async virtual Task<TOther> GetAsync<TOther>()
        {
            var web = CreateWebRequest("GET");
            var json = "";

            try
            {
                var response = await web.GetResponseAsync();

                var answer = new StreamReader(response.GetResponseStream());
                json = answer.ReadToEnd();

                return Newtonsoft.Json.JsonConvert.DeserializeObject<TOther>(json);
            }
            catch (WebException ex)
            {
                throw ProcessWebException(ex);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected async Task<TOther> SendRequestWithBodyAsync<TOther>(TOther entity, string method)
        {
            var request = CreateWebRequest(method);

            var data = "";
            if (entity != null)
                data = SerializeToJson(entity);

            //Our postvars
            byte[] buffer = Encoding.UTF8.GetBytes(data);

            //The length of the buffer (postvars) is used as contentlength.
            //request.ContentLength = buffer.Length;
            //We open a stream for writing the postvars
            var postData = await request.GetRequestStreamAsync();
            //Now we write, and afterwards, we close. Closing is always important!
            postData.Write(buffer, 0, buffer.Length);
            postData.Close();
            //Get the response handle, we have no true response yet!

            var json = "";
            try
            {
                using (var response = await request.GetResponseAsync())
                {
                    //Let's show some information about the response
                    var statusCode = ((HttpWebResponse)response).StatusCode;

                    using (StreamReader answer = new StreamReader(response.GetResponseStream()))
                        json = answer.ReadToEnd();

                    if (statusCode == HttpStatusCode.Created || statusCode == HttpStatusCode.OK)
                        entity = Newtonsoft.Json.JsonConvert.DeserializeObject<TOther>(json);

                }
            }
            catch (WebException ex)
            {
                throw ProcessWebException(ex);
            }
            catch (Exception ex)
            {
                throw;
            }

            return entity;
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Builds the Uri for the request to Assembla API
        /// </summary>
        /// <returns></returns>
        protected virtual Uri GetRequestUri()
        {
            var parameters = BaseUriParameters.ToList();

            if (parameters.Count > 1 && parameters[0] == SpacesUriPath)
            {
                if (string.IsNullOrEmpty(Configuration.SpaceName))
                    throw new Exception("In order to use Space specific nAssembla methods, a Space id must be set in configuration.");
                parameters.Insert(1, Configuration.SpaceName);
            }

            if (AdditionalUriParameters != null && AdditionalUriParameters.Length > 0)
                parameters.AddRange(AdditionalUriParameters);

            var queryParams = new List<string>();
            if (AdditionalUriQueryParameters != null && AdditionalUriQueryParameters.Count > 0)
                queryParams.AddRange(AdditionalUriQueryParameters.Select(q => q.Key + "=" + q.Value));

            var url = Path.Combine(Configuration.VersionedApiUrl,
                string.Join("/", parameters.ToArray()));

            if (queryParams.Count > 0)
                url += "?" + string.Join("&", queryParams.ToArray());

            return new Uri(url);
        }

        private string SerializeToJson(object entity)
        {
            var data = Newtonsoft.Json.JsonConvert.SerializeObject(entity, Newtonsoft.Json.Formatting.None, new Newtonsoft.Json.JsonSerializerSettings()
            {
                ContractResolver = new UpdatableContractResolver(),
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                //DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.IgnoreAndPopulate,
            });

            var objectAttribute = entity.GetType().GetCustomAttributes(typeof(JsonObjectAttribute), false);
            if (objectAttribute != null && objectAttribute.Length > 0)
            {
                //Wrap the json in a root if we have a title
                data = string.Format("{{\"{0}\":{1}}}", ((JsonObjectAttribute)objectAttribute[0]).Title, data);
            }
            return data;
        }

        private Exception ProcessWebException(WebException ex)
        {
            var resp = "";

            using (var stream = ex.Response.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                    resp = sr.ReadToEnd().Trim();
                stream.Close();
            }

            if (!string.IsNullOrEmpty(resp))
            {
                try
                {
                    var error = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO.Error>(resp);
                    throw new Exception(error.ErrorType + ": " + error.Description);
                }
                catch (Exception)
                {
                    return ex;
                }

            }
            else
                return ex;
        }

        //protected virtual void OnError(Exception ex)
        //{
        //    var eh = Error;
        //    if (eh != null)
        //        eh(this, new nAssemblaExceptionEventArgs(ex));
        //}

        #endregion

        //public event EventHandler<nAssemblaExceptionEventArgs> Error;
    }

    public abstract class ProxyBase<T, TKey> : ProxyReadOnlyBase<T>
       where T : DTO.DTOBase, new()
    {
        #region Methods

        public async virtual Task<T> GetAsync(TKey key, bool forceRefresh = false)
        {
            var data = default(T);
            if (key != null && !key.Equals(default(TKey)) && DataIsCachable && DataCache != null && !forceRefresh)
            {
                data = DataCache.SingleOrDefault(d => d.KeyValue.Equals(key));
            }
            if (data == null)
            {
                if (key != null && !key.Equals(default(TKey)))
                    AdditionalUriParameters = new string[] { key.ToString() };
                var web = CreateWebRequest("GET");

                var response = await web.GetResponseAsync();

                var answer = new StreamReader(response.GetResponseStream());
                var responseData = answer.ReadToEnd();

                data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseData);
            }

            return data;
        }

        public async virtual Task<TOther> CreateAsync<TOther>(TOther entity)
            where TOther : DTO.DTOBase
        {
            var data = await SendRequestWithBodyAsync(entity, "POST");           
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="CreateEntityException">If there was an issue creating the entity.</exception>
        public async virtual Task<T> CreateAsync(T entity)
        {
            var data = await SendRequestWithBodyAsync(entity, "POST");
            if (DataIsCachable && DataCache != null)
            {
                var item = DataCache.SingleOrDefault(i => i.KeyValue.Equals(entity.KeyValue));
                if (item != null)
                    item = data;
                else
                    DataCache.Add(data);
            }
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="CreateEntityException">If there was an issue creating the entity.</exception>
        public async virtual Task<TOther> UpdateAsync<TOther>(TOther entity)
            where TOther : DTO.DTOBase
        {
            AdditionalUriParameters = new string[] { entity.KeyValue.ToString() };
            var data = await SendRequestWithBodyAsync(entity, "PUT");            
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="CreateEntityException">If there was an issue creating the entity.</exception>
        public async virtual Task<T> UpdateAsync(T entity)
        {
            AdditionalUriParameters = new string[] { entity.KeyValue.ToString() };
            var data = await SendRequestWithBodyAsync(entity, "PUT");
            if (DataIsCachable && DataCache != null)
            {
                var item = DataCache.SingleOrDefault(i => i.KeyValue.Equals(entity.KeyValue));
                if (item != null)
                    item = data;
                else
                    DataCache.Add(data);
            }
            return data;
        }

        #endregion
    }

    public abstract class AttachmentAwareProxyBase<T, TKey> :
        ProxyBase<T, TKey> where T : DTO.DTOAttachmentAwareBase, new()
    {

#if !SILVERLIGHT

        protected override string[] BaseUriParameters
        {
            get
            {
                // TODO: Implement this property getter
                throw new NotImplementedException();
            }
        }

        public T AttachFileTo(T entity, string name, FileInfo file)
        {
            var mimeType = getMimeFromFile(file.FullName);
            var doc = UploadDocument(name, file.FullName, mimeType,
                entity.AttachableType, entity.KeyValue.ToString());

            entity.Attachments.Add(doc);

            return entity;
        }

        private DTO.Document UploadDocument(string documentName, string filePath,
            string fileContentType, nAssembla.DTO.Enums.AttachableType attachableType, string attachableTypeId)
        {
            var url = base.GetRequestUri().ToString();
            string fileParamName = "document[file]";
            NameValueCollection otherFields = new NameValueCollection();
            otherFields.Add("document[name]", documentName);

            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
            wr.ContentType = "multipart/form-data; boundary=" + boundary;
            wr.Method = "POST";

            Stream rs = wr.GetRequestStream();

            string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
            foreach (string key in otherFields.Keys)
            {
                rs.Write(boundarybytes, 0, boundarybytes.Length);
                string formitem = string.Format(formdataTemplate, key, otherFields[key]);
                byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                rs.Write(formitembytes, 0, formitembytes.Length);
            }
            rs.Write(boundarybytes, 0, boundarybytes.Length);

            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
            string header = string.Format(headerTemplate, fileParamName, filePath, fileContentType);
            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
            rs.Write(headerbytes, 0, headerbytes.Length);

            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[4096];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                rs.Write(buffer, 0, bytesRead);
            }
            fileStream.Close();

            byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
            rs.Write(trailer, 0, trailer.Length);
            rs.Close();

            DTO.Document doc = new DTO.Document();
            WebResponse wresp = null;
            try
            {
                wresp = wr.GetResponse();
                Stream stream2 = wresp.GetResponseStream();
                StreamReader reader2 = new StreamReader(stream2);
            }
            catch (Exception ex)
            {
                if (wresp != null)
                {
                    wresp.Close();
                    wresp = null;
                }
            }
            finally
            {
                wr = null;
            }

            return doc;
        }

        private string getMimeFromFile(string filename)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException(filename + " not found");

            byte[] buffer = new byte[256];
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                if (fs.Length >= 256)
                    fs.Read(buffer, 0, 256);
                else
                    fs.Read(buffer, 0, (int)fs.Length);
            }
            try
            {
                System.UInt32 mimetype;
                Helper.FindMimeFromData(0, null, buffer, 256, null, 0, out mimetype, 0);
                System.IntPtr mimeTypePtr = new IntPtr(mimetype);
                string mime = Marshal.PtrToStringUni(mimeTypePtr);
                Marshal.FreeCoTaskMem(mimeTypePtr);
                return mime;
            }
            catch (Exception e)
            {
                return "unknown/unknown";
            }
        }

#endif
    }
}
