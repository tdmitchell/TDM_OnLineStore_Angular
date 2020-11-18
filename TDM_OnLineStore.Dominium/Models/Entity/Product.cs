using System;
using System.Collections.Generic;
using System.Text;

namespace TDM_OnLineStore.Dominium.Models.Entity
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //public string NomeArquivo { get; set; }

        #region Validation / Business Rules
        public override void Validate()
        {
            EmptyValidationMessage();

            if (string.IsNullOrEmpty(Name))
                AddWarn("WARN: Please inform the Product's Name");
            if (string.IsNullOrEmpty(Description))
                AddWarn("WARN: Please inform the Product's Description");
            if (string.IsNullOrEmpty(Price.ToString()))
                AddWarn("WARN: Please inform the Product's Price");
            //if (!(Price == null))
            //    AddWarn("WARN: Please inform the Product's Price");
        }
        #endregion
    }
}
