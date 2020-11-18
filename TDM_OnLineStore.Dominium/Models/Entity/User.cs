using System;
using System.Collections.Generic;
using System.Text;

namespace TDM_OnLineStore.Dominium.Models.Entity
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }

        /// <summary>
        /// User can do 1 or Many orders
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }

        #region Validation / Business Rules
        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AddWarn("WARN: Please inform the Email");

            if (string.IsNullOrEmpty(Password))
                AddWarn("WARN: Please inform the Password");
        }
        #endregion

    }
}
