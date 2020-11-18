using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDM_OnLineStore.Dominium.Models.Entity
{
    public abstract class Entity
    {
        #region VALIDATION  
        private List<string> _validationMessage { get; set; }
        private List<string> validationMessage
        {
            get { return _validationMessage ?? (_validationMessage = new List<string>()); }
        }

        protected void EmptyValidationMessage()
        {
            validationMessage.Clear();
        }

        protected void AddWarn(string message)
        {
            validationMessage.Add(message);
        }

        //public string ObterMensagensValidacao GetValidationMessage()
        //{
        //    return string.Join(". ", validationMessage);
        //}

        //Method to be implemented by all classes to Validate each class
        public abstract void Validate();

        //If there is no Validation Message the class IS VALID
        public bool IsValid
        {
            get { return !validationMessage.Any(); }
        }
        #endregion
    }
}
