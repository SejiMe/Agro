﻿// <auto-generated />
using System;
using Agro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agro.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231201142021_AddedMembershipApplication")]
    partial class AddedMembershipApplication
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Agro.Data.Models.Address", b =>
                {
                    b.Property<int>("PK_Address")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_Address"));

                    b.Property<string>("Barangay")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HouseNumber")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LotNumber")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Street")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("PK_Address");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Agro.Data.Models.Farm", b =>
                {
                    b.Property<Guid?>("PK_Farm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Address")
                        .HasColumnType("int");

                    b.Property<int>("AreaSQM")
                        .HasColumnType("int");

                    b.Property<string>("CommodityName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("EastAdjacentOwner")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid?>("FK_UserPK_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LandCategorySoilType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NorthAdjacentOwner")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("Personal")
                        .HasColumnType("int");

                    b.Property<string>("SouthAdjacentOwner")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TenurialStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WastAdjacentOwner")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("isHVCDP")
                        .HasColumnType("bit");

                    b.HasKey("PK_Farm");

                    b.HasIndex("Address");

                    b.HasIndex("FK_UserPK_User");

                    b.HasIndex("Personal");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("Agro.Data.Models.Insurance", b =>
                {
                    b.Property<Guid>("PK_Insurance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateApplied")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("FK_FarmPK_Farm")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FK_UserPK_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("PersonalPK_Personal")
                        .HasColumnType("int");

                    b.Property<bool>("Remarks")
                        .HasColumnType("bit");

                    b.HasKey("PK_Insurance");

                    b.HasIndex("FK_FarmPK_Farm");

                    b.HasIndex("FK_UserPK_User");

                    b.HasIndex("PersonalPK_Personal");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("Agro.Data.Models.Personal", b =>
                {
                    b.Property<int>("PK_Personal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_Personal"));

                    b.Property<string>("Association")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<Guid>("FK_UserPK_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(1)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SpouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("civil_status")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("PK_Personal");

                    b.HasIndex("FK_UserPK_User");

                    b.ToTable("Personals");
                });

            modelBuilder.Entity("Agro.Data.Models.PersonalAddress", b =>
                {
                    b.Property<int>("FK_Personal")
                        .HasColumnType("int");

                    b.Property<int>("FK_Address")
                        .HasColumnType("int");

                    b.HasKey("FK_Personal", "FK_Address");

                    b.HasIndex("FK_Address");

                    b.ToTable("PersonalAddresses");
                });

            modelBuilder.Entity("Agro.Data.Models.User", b =>
                {
                    b.Property<Guid?>("PK_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("PK_User");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Agro.Data.Models.Farm", b =>
                {
                    b.HasOne("Agro.Data.Models.Address", "FK_Address")
                        .WithMany()
                        .HasForeignKey("Address");

                    b.HasOne("Agro.Data.Models.User", "FK_User")
                        .WithMany()
                        .HasForeignKey("FK_UserPK_User");

                    b.HasOne("Agro.Data.Models.Personal", "FK_Personal")
                        .WithMany()
                        .HasForeignKey("Personal");

                    b.Navigation("FK_Address");

                    b.Navigation("FK_Personal");

                    b.Navigation("FK_User");
                });

            modelBuilder.Entity("Agro.Data.Models.Insurance", b =>
                {
                    b.HasOne("Agro.Data.Models.Farm", "FK_Farm")
                        .WithMany("Insurances")
                        .HasForeignKey("FK_FarmPK_Farm");

                    b.HasOne("Agro.Data.Models.User", "FK_User")
                        .WithMany()
                        .HasForeignKey("FK_UserPK_User");

                    b.HasOne("Agro.Data.Models.Personal", null)
                        .WithMany("Insurances")
                        .HasForeignKey("PersonalPK_Personal");

                    b.Navigation("FK_Farm");

                    b.Navigation("FK_User");
                });

            modelBuilder.Entity("Agro.Data.Models.Personal", b =>
                {
                    b.HasOne("Agro.Data.Models.User", "FK_User")
                        .WithMany()
                        .HasForeignKey("FK_UserPK_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FK_User");
                });

            modelBuilder.Entity("Agro.Data.Models.PersonalAddress", b =>
                {
                    b.HasOne("Agro.Data.Models.Address", "Address")
                        .WithMany("FK_PersonalAddresses")
                        .HasForeignKey("FK_Address")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agro.Data.Models.Personal", "Personal")
                        .WithMany("FK_PersonalAddress")
                        .HasForeignKey("FK_Personal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Agro.Data.Models.Address", b =>
                {
                    b.Navigation("FK_PersonalAddresses");
                });

            modelBuilder.Entity("Agro.Data.Models.Farm", b =>
                {
                    b.Navigation("Insurances");
                });

            modelBuilder.Entity("Agro.Data.Models.Personal", b =>
                {
                    b.Navigation("FK_PersonalAddress");

                    b.Navigation("Insurances");
                });
#pragma warning restore 612, 618
        }
    }
}
