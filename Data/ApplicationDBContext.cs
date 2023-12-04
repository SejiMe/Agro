using Agro.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data;

public class ApplicationDBContext : DbContext
{
    

    public ApplicationDBContext()
    {

    }



    public DbSet<User> Users { get; set; } 
    public DbSet<Personal> Personals { get; set; } 
    public DbSet<Address> Addresses { get; set; } 

    public DbSet<PersonalAddress> PersonalAddresses { get; set; }

    public DbSet<Farm> Farms { get; set; } 
    //public DbSet<Commodity> Commodities { get; set; }
    
    //public DbSet<FarmCommodity> FarmCommodities { get; set; }

    public DbSet<Insurance> Insurances { get; set; }
    public DbSet<MembershipApplication> MembershipApplications { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Farm Commodity
        //modelBuilder.Entity<FarmCommodity>()
        //    .HasKey(join => new { join.FK_Farm, join.FK_Commodity });

        //modelBuilder.Entity<FarmCommodity>()
        //    .HasOne(join => join.Farm)
        //    .WithMany(farm => farm.FarmCommodities)
        //    .HasForeignKey(join => join.FK_Farm);
        
        //modelBuilder.Entity<FarmCommodity>()
        //    .HasOne(join => join.Commodity)
        //    .WithMany(commodity => commodity.FarmCommodities)
        //    .HasForeignKey(join => join.FK_Commodity);
        #endregion
        
        #region Personal Address
        modelBuilder.Entity<PersonalAddress>()
            .HasKey(join => new { join.FK_Personal, join.FK_Address });

        modelBuilder.Entity<PersonalAddress>()
            .HasOne(join => join.Personal)
            .WithMany(personal => personal.FK_PersonalAddress)
            .HasForeignKey(join => join.FK_Personal);
        
        modelBuilder.Entity<PersonalAddress>()
            .HasOne(join => join.Address)
            .WithMany(address => address.FK_PersonalAddresses)
            .HasForeignKey(join => join.FK_Address);
        #endregion


        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MSITConnection"].ConnectionString);
        base.OnConfiguring(optionsBuilder);
    }
}
