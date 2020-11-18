using System;
using System.Collections.Generic;
using System.Text;

namespace TDM_OnLineStore.Dominium.Models.Entity
{
    public class OrderItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        #region Validation / Business Rules
        public override void Validate()
        {
            if (ProductId == 0)
                AddWarn("WARN: The product was not found");

            if (Quantity == 0)
                AddWarn("WARN: Please inform the quantity");
        }
        #endregion
    }
}
