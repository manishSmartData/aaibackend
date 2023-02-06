using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.DataContract.Models.Entity
{
    public class Users
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }    
        public string LastName { get; set; }    
        public string Email { get; set; }   
        public string Password { get; set; }    
        //public bool IsActive { get; set; }    
        //public DateTime? CreatedOn { get; set; }
        //public int CreatedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        //public int ModifiedBy { get; set; }      
        
    }
}
