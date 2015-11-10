using System;

namespace nAssembla.Proxy
{
    public class ActivityProxy : ProxyReadOnlyBase<DTO.Event> 
    {
        private DateTime? _dateFrom;
        private DateTime? _dateTo;
        private string _spaceId;

        public ActivityProxy()
        {
        }

        public ActivityProxy(string spaceId = null, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
            SpaceId = spaceId;
        }        

        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { "activity" };
            }
        }

        public DateTime? DateFrom
        {
            get
            {
                return this._dateFrom;
            }
            set
            {               
                this._dateFrom = value;
                if (value.HasValue)
                    AdditionalUriQueryParameters["from"] = value.Value.ToString("yyyy-MM-dd hh:mm");
                else
                    AdditionalUriQueryParameters.Remove("from");
            }
        }
        
        public DateTime? DateTo
        {
            get
            {
                return this._dateTo;
            }
            set
            {
                this._dateTo = value;
                if (value.HasValue)
                    AdditionalUriQueryParameters["to"] = value.Value.ToString("yyyy-MM-dd hh:mm");
                else
                    AdditionalUriQueryParameters.Remove("to");
            }
        }

        public string SpaceId
        {
            get
            {
                return this._spaceId;
            }
            set
            {
                this._spaceId = value;
                if (!string.IsNullOrWhiteSpace(value))
                    AdditionalUriQueryParameters["space_id"] = value;
                else
                    AdditionalUriQueryParameters.Remove("space_id");
            }
        }


    }
}