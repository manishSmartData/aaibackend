using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.DataContract.Models.Entity.DB
{
    public class entitycontext : DbContext
    {
       

        public entitycontext(DbContextOptions<entitycontext> options): base(options)
        {

        }


        //public virtual DbSet<AAI_ActSection> AAI_ActSection { get; set; }
        //public virtual DbSet<AAI_Allocations> AAI_Allocations { get; set; }
        //public virtual DbSet<AAI_Authorizations> AAI_Authorizations { get; set; }
        //public virtual DbSet<AAI_BondCounsels> AAI_BondCounsels { get; set; }
        //public virtual DbSet<AAI_FundDescription> AAI_FundDescription { get; set; }
        //public virtual DbSet<AAI_Issuance> AAI_Issuance { get; set; }
        //public virtual DbSet<PasteErrors> PasteErrors { get; set; }
        //public virtual DbSet<Sheet1> Sheet1 { get; set; }
        //public virtual DbSet<Switchboard_Items> Switchboard_Items { get; set; }
        //public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<User1> User1 { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //connection string
        //    optionsBuilder.UseSqlServer("Server=CPC-dev5-5870R6\\MSSQLSERVER01;Database=AAI;Persist Security Info=True;Connection Timeout=30;Encrypt=false;TrustServerCertificate=true");
        //}
    }
}
