using System;
using System.Collections.Generic;
using System.Text;
using TDM_OnLineStore.Dominium.Models.ENUM;

namespace TDM_OnLineStore.Dominium.Models.Entity
{
    public class Payment : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsBoleto
        {
            get { return Id == (int)PaymenteTypesEnum.Boleto; }
        }

        public bool IsCredictCard
        {
            get { return Id == (int)PaymenteTypesEnum.CredictCard; }
        }

        public bool IsDeposit
        {
            get { return Id == (int)PaymenteTypesEnum.Deposit; }
        }

        public bool IsNotDefined
        {
            get { return Id == (int)PaymenteTypesEnum.NotDefined; }
        }

        #region Validation / Business Rules
        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))                              // ------------------------ !!!! TO CHECK !!!! ------------------------ 
                AddWarn("WARN: Please inform the payment's name");

            if (string.IsNullOrEmpty(Description))
                AddWarn("WARN: Please inform the payment's description");
        }
        #endregion
    }
}
