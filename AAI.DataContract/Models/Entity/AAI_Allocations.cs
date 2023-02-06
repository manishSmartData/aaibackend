using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.DataContract.Models.Entity
{
    public class AAI_Allocations
    {
        public int Id { get; set; } 
        public string Fund { get; set; }
        public string ActandSection { get; set; }
        public string BondCounsel { get; set; }
        public Nullable<double> AllocationAmount { get; set; }
        public string AllocationDate { get; set; }
        public Nullable<bool>  Active { get; set; }
        public DateAndTime SSMA_TimeStamp { get; set; }
    }
}
