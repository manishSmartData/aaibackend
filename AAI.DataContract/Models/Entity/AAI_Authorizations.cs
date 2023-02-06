using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.DataContract.Models.Entity
{
    public  class AAI_Authorizations
    {
        public int Id { get; set; }
        public int Fund { get; set; }
        public string? BondCounsel { get; set; }
        public double? AuthorizationAmount { get; set; }
        public DateTime? AuthorizationDate { get; set; }
        public bool? Active { get; set; }
        public string? Field1 { get; set; }
        public bool? Reassigned { get; set; }
        public DateTime SSMA_TimeStamp { get; set; }

    }
}
