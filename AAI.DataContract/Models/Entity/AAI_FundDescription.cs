using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.DataContract.Models.Entity
{
    public class AAI_FundDescription
    {
        public int Id { get; set; }
        public double? Fund { get; set; }    
        public string Description { get; set; }    
        public string ProgramType { get; set; }    
        public DateTime? SSMA_TimeStamp { get; set; }    

        
    }
}
