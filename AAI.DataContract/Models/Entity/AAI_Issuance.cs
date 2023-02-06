using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.DataContract.Models.Entity
{
    public class AAI_Issuance
    {
        public int Id { get; set; } 
        public string ActandSection { get; set; }    
        public string BondCounsel { get; set; }    
        public double?  IssuedAmount { get; set; }    
        public DateTime?  IssuedDate  { get; set; }    
        public string ClearedTE  { get; set; }
        public string ClearedTax  { get; set; }
        public string Notes  { get; set; }
        public string Field1  { get; set; }
        public DateTime SSMA_TimeStamp { get; set; }
        
    }
}
