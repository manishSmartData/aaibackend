using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.DataContract.Models.Entity
{
    public class Section
    {
        public string Section_ID { get; set; }
        public string Act { get; set; }
            
        public string Sub_Section { get; set; }
        public string Sub_Section_Description { get; set; }
        public string Fund_ID { get; set; }

        public string DBC_Sub_Section { get; set; }
        public string Core_Account_Number { get; set; }
        public Nullable<bool> Exclude_from_Reports { get; set; }
        public Nullable<bool> IsLocked { get; set; }
        public string Change_ID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

    }
}
