using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDM_OnLineStore.Dominium.Models.Entity
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        
        //Relashionship with User
        public int UserId { get; set; }
        public virtual User User { get; set; }

        #region Address
        /// <summary>
        /// Address Should be created as a new Class
        /// </summary>
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        #endregion

        #region Payment
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
        #endregion

        /// <summary>
        /// Order MUST have at least 1 OrderItem
        /// </summary>
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        #region Validation / Business Rules
        public override void Validate()
        {
            EmptyValidationMessage();

            if (!OrderItems.Any())
                AddWarn("WARN: Order must have at list 1 order item.");

            if (string.IsNullOrEmpty(PostalCode))
                AddWarn("WARN: Postal code must not be empty.");

            if (PaymentId == 0)
                AddWarn("WARN: You need to inform the payment type.");
        }
        #endregion
    }
}
