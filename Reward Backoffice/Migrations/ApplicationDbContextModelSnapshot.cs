﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reward_Backoffice.Data;

namespace Reward_Backoffice.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Reward_Backoffice.Models.ApplicationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationType");
                });

            modelBuilder.Entity("Reward_Backoffice.Models.Branch", b =>
                {
                    b.Property<int>("branch_table_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("added_by")
                        .HasColumnType("int");

                    b.Property<string>("branch_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date_added")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("branch_table_id");

                    b.ToTable("z3s1o_branch");
                });

            modelBuilder.Entity("Reward_Backoffice.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Reward_Backoffice.Models.Client", b =>
                {
                    b.Property<int>("client_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PermRes")
                        .HasColumnType("bit");

                    b.Property<string>("UserIDHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("balance_reward_points")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("branch_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("bumi")
                        .HasColumnType("bit");

                    b.Property<string>("client_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("client_tier_id")
                        .HasColumnType("int");

                    b.Property<string>("client_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_added")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("race")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<string>("telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trading_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("client_id");

                    b.ToTable("z3s1o_client");
                });

            modelBuilder.Entity("Reward_Backoffice.Models.Dealer", b =>
                {
                    b.Property<int>("DealerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("cost_sharing")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("DealerId");

                    b.ToTable("z3s1o_dealers");
                });
#pragma warning restore 612, 618
        }
    }
}
