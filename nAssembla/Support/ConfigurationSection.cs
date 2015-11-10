using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace nAssembla
{
    public class ConfigurationSection : System.Configuration.ConfigurationSection
    {        
        [ConfigurationProperty("baseUrl", DefaultValue = "http://www.assembla.com/", IsRequired = false)]
        public string BaseUrl
        {
            get
            {
                return (string)this["baseUrl"];
            }
            set
            {
                this["baseUrl"] = value;
            }
        }

        [ConfigurationProperty("userName", IsRequired = true)]
        public string UserName
        {
            get
            {
                return (string)this["userName"];
            }
            set
            {
                this["userName"] = value;
            }
        }

        [ConfigurationProperty("password", IsRequired = true)]
        public string Password
        {
            get
            {
                return (string)this["password"];
            }
            set
            {
                this["password"] = value;
            }
        }

        [ConfigurationProperty("spaceName", IsRequired = true)]
        public string SpaceName
        {
            get
            {
                return (string)this["spaceName"];
            }
            set
            {
                this["spaceName"] = value;
            }
        }

        [ConfigurationProperty("apiKey", IsRequired = true)]
        public string ApiKey
        {
            get
            {
                return (string)this["apiKey"];
            }
            set
            {
                this["apiKey"] = value;
            }
        }

        [ConfigurationProperty("apiSecret", IsRequired = true)]
        public string ApiSecret
        {
            get
            {
                return (string)this["apiSecret"];
            }
            set
            {
                this["apiSecret"] = value;
            }
        }

        [ConfigurationProperty("clientKey")]
        public string ClientKey
        {
            get
            {
                return (string)this["clientKey"];
            }
            set
            {
                this["clientKey"] = value;
            }
        }

        [ConfigurationProperty("clientSecret")]
        public string ClientSecret
        {
            get
            {
                return (string)this["clientSecret"];
            }
            set
            {
                this["clientSecret"] = value;
            }
        }


    }    

}
