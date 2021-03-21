﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using remittance.api.Data;

namespace remittance.api.Migrations
{
    [DbContext(typeof(DatalayerContext))]
    [Migration("20210320131937_added_branch_model")]
    partial class added_branch_model
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("remittance.api.Model.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaseCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchCode")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<bool>("BranchStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReceiveFromMMT")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReceiveTMTFromPartner")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CommForPayingBranch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("CommForPayingBranchStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("MmtCommForSending")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("MmtCommForSendingStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Payee")
                        .HasColumnType("bit");

                    b.Property<string>("ReferenceBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TmtCommForSending")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("TmtCommForSendingStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });
#pragma warning restore 612, 618
        }
    }
}
