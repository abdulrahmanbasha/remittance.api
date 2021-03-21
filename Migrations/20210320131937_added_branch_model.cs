using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace remittance.api.Migrations
{
    public partial class added_branch_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchStatus = table.Column<bool>(type: "bit", nullable: false),
                    Payee = table.Column<bool>(type: "bit", nullable: false),
                    CanReceiveFromMMT = table.Column<bool>(type: "bit", nullable: false),
                    CanReceiveTMTFromPartner = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TmtCommForSending = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TmtCommForSendingStatus = table.Column<bool>(type: "bit", nullable: true),
                    MmtCommForSending = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MmtCommForSendingStatus = table.Column<bool>(type: "bit", nullable: true),
                    CommForPayingBranch = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CommForPayingBranchStatus = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
