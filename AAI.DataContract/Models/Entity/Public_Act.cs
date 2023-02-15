using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.DataContract.Models.Entity
{
    public class Public_Act
    {
        public string ACT_ID { get; set; }
        public string Act { get; set; }

        public DateTime Adoption_Date { get; set; }
        public string Act_File { get; set; }
        public Nullable<bool> Exclude_From_Reports { get; set; }
        public Nullable<bool> IsLocked { get; set; }
        public string Change_ID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
