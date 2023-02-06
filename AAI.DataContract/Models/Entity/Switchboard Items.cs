using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.DataContract.Models.Entity
{
    public class Switchboard_Items
    {
        public int SwitchboardID { get; set; }
        public int ItemNumber { get; set;}
        public string ItemText { get; set;}
        public int? Command { get; set;} 
        public string Argument { get; set;} 
    }
}
