﻿// <auto-generated />
using System;
using BD_of_the_Insurance_Company.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BD_of_the_Insurance_Company.Migrations
{
    [DbContext(typeof(BD_of_the_Insurance_CompanyContext))]
    [Migration("20201101103817_5")]
    partial class _5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Client", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long>("Client_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Full_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("GroupsID")
                        .HasColumnType("bigint");

                    b.Property<string>("Passport_data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PoliciesID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("PoliciesID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Groups", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ClientID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Groups_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Groups_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Policies", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClientsID")
                        .HasColumnType("bigint");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("End_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("End_mark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Payment_amount")
                        .HasColumnType("int");

                    b.Property<string>("Payment_mark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Policies_ID")
                        .HasColumnType("bigint");

                    b.Property<long>("Policy_typeID")
                        .HasColumnType("bigint");

                    b.Property<long>("StaffID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Start_date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Policy_type", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Conditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PoliciesID")
                        .HasColumnType("bigint");

                    b.Property<long>("Policy_type_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Policy_type_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RisksID1")
                        .HasColumnType("bigint");

                    b.Property<long>("RisksID2")
                        .HasColumnType("bigint");

                    b.Property<long>("RisksID3")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("PoliciesID");

                    b.ToTable("Policy_type");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Position", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Position_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Position_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Risks", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Average_Probability")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Policy_typeID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Policy_typeID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("Policy_typeID2")
                        .HasColumnType("bigint");

                    b.Property<long>("Risks_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Risks_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Policy_typeID");

                    b.HasIndex("Policy_typeID1");

                    b.HasIndex("Policy_typeID2");

                    b.ToTable("Risks");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Full_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport_data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PoliciesID")
                        .HasColumnType("bigint");

                    b.Property<long>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<long>("Staff_ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("PoliciesID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Client", b =>
                {
                    b.HasOne("BD_of_the_Insurance_Company.Models.Policies", null)
                        .WithMany("Clients_ID")
                        .HasForeignKey("PoliciesID");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Groups", b =>
                {
                    b.HasOne("BD_of_the_Insurance_Company.Models.Client", null)
                        .WithMany("Groups_ID")
                        .HasForeignKey("ClientID");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Policy_type", b =>
                {
                    b.HasOne("BD_of_the_Insurance_Company.Models.Policies", null)
                        .WithMany("Policy_type_ID")
                        .HasForeignKey("PoliciesID");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Position", b =>
                {
                    b.HasOne("BD_of_the_Insurance_Company.Models.Staff", null)
                        .WithMany("Position_ID")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Risks", b =>
                {
                    b.HasOne("BD_of_the_Insurance_Company.Models.Policy_type", null)
                        .WithMany("Risks_ID1")
                        .HasForeignKey("Policy_typeID");

                    b.HasOne("BD_of_the_Insurance_Company.Models.Policy_type", null)
                        .WithMany("Risks_ID2")
                        .HasForeignKey("Policy_typeID1");

                    b.HasOne("BD_of_the_Insurance_Company.Models.Policy_type", null)
                        .WithMany("Risks_ID3")
                        .HasForeignKey("Policy_typeID2");
                });

            modelBuilder.Entity("BD_of_the_Insurance_Company.Models.Staff", b =>
                {
                    b.HasOne("BD_of_the_Insurance_Company.Models.Policies", null)
                        .WithMany("Staff_ID")
                        .HasForeignKey("PoliciesID");
                });
#pragma warning restore 612, 618
        }
    }
}
