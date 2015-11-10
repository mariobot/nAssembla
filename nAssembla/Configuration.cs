using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;

namespace nAssembla
{
    public static class Configuration //: ConfigurationElement
    {
        #region Fields

        public const int ApiVersion = 1;

        private static string userName;
        private static string password;
        private static string clientId;
        private static string clientSecret;
        private static string apiKey;
        private static string apiSecret;
        private static string baseUrl = "https://www.assembla.com/";
        private static string baseApiUrl = "https://api.assembla.com/";
        private static string spaceName;
        private static string spaceId;

        #endregion

        /// <summary>
        /// Gets or sets the Base URL for Assembla (defaults to https://www.assembla.com/)
        /// </summary>
        public static string BaseUrl
        {
            get { return baseUrl; }
            set { baseUrl = value; }
        }

        /// <summary>
        /// Gets or sets the Base URL for the API (defaults to https://api.assembla.com/)
        /// </summary>
        public static string BaseApiUrl
        {
            get { return baseApiUrl; }
            set { baseApiUrl = value; }
        }
        
        public static string VersionedApiUrl
        {
            get { return Path.Combine(baseApiUrl, "v" + ApiVersion.ToString()); }
        }

        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public static string Password
        {
            get { return password; }
            set { password = value; }
        }

        public static string ApiKey
        {
            get { return apiKey; }
            set { apiKey = value; }
        }

        public static string ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        public static string ClientSecret
        {
            get { return clientSecret; }
            set { clientSecret = value; }
        }

        public static string ApiSecret
        {
            get { return apiSecret; }
            set { apiSecret = value; }
        } 

        public static string SpaceName
        {
            get { return spaceName; }
            set { spaceName = value; }
        }

        public static string SpaceId
        {
            get { return spaceId; }
            set { spaceId = value; }
        }

        internal static string TokenType { get; set; }
        internal static string AccessToken { get; set; }
        internal static int TokenExpiry { get; set; }
        internal static string RefreshToken { get; set; }
    }
}
