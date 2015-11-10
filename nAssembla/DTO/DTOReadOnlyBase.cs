using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace nAssembla.DTO
{
    /// <summary>
    /// Represents an Assembla DTO object, which does not support update operations.
    /// All properties of Entities inheriting on DTOReadOnlyBase should have private setters.
    /// </summary>
    public abstract class DTOReadOnlyBase : INotifyPropertyChanged
    {
        
        #region Fields

        private DateTime _createdOn;

        private DateTime? _updatedAt;

        private List<string> _errors;

        #endregion

        #region Properties
        
        /// <summary>
        /// Gets the date the Entity was created
        /// </summary>
        [JsonProperty("created_on")]
        public DateTime CreatedOn
        {
            get
            {
                return _createdOn;
            }
            set
            {
                ChangeProperty(ref _createdOn, value, "CreatedOn");
            }
        }
        
        /// <summary>
        /// Gets the date the entity was last updated
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt
        {
            get
            {
                return _updatedAt;
            }
            set
            {
                ChangeProperty(ref _updatedAt, value, "UpdatedAt");
            }
        }
        
        /// <summary>
        /// Gets a list of errors associated with an update to an entity
        /// </summary>
        public List<string> Errors
        {
            get
            {
                return _errors;
            }
            protected set
            {
                ChangeProperty(ref _errors, value, "Errors");
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Protected Methods
        
        protected void ChangeProperty<T>(ref T backingField, T newValue, string propertyName)
        {
            if (backingField != null && backingField.Equals(newValue))
                return;
            
            backingField = newValue;
            OnPropertyChanged(propertyName);
        }
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var eh = PropertyChanged;
            if (eh != null)
                eh(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}