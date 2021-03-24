using Microsoft.EntityFrameworkCore.Migrations;

namespace remittance.api.Migrations
{
    public partial class changed_branch_properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Branches",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "TmtCommForSendingStatus",
                table: "Branches",
                newName: "tmtCommForSendingStatus");

            migrationBuilder.RenameColumn(
                name: "TmtCommForSending",
                table: "Branches",
                newName: "tmtCommForSending");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Branches",
                newName: "telephone");

            migrationBuilder.RenameColumn(
                name: "ReferenceBranch",
                table: "Branches",
                newName: "referenceBranch");

            migrationBuilder.RenameColumn(
                name: "ParentBranch",
                table: "Branches",
                newName: "parentBranch");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Branches",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MmtCommForSendingStatus",
                table: "Branches",
                newName: "mmtCommForSendingStatus");

            migrationBuilder.RenameColumn(
                name: "MmtCommForSending",
                table: "Branches",
                newName: "mmtCommForSending");

            migrationBuilder.RenameColumn(
                name: "Fax",
                table: "Branches",
                newName: "fax");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Branches",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Domain",
                table: "Branches",
                newName: "domain");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Branches",
                newName: "createdon");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Branches",
                newName: "createdby");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Branches",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "CommForPayingBranchStatus",
                table: "Branches",
                newName: "commForPayingBranchStatus");

            migrationBuilder.RenameColumn(
                name: "CommForPayingBranch",
                table: "Branches",
                newName: "commForPayingBranch");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Branches",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "CanReceiveTMTFromPartner",
                table: "Branches",
                newName: "canReceiveTMTFromPartner");

            migrationBuilder.RenameColumn(
                name: "CanReceiveFromMMT",
                table: "Branches",
                newName: "canReceiveFromMMT");

            migrationBuilder.RenameColumn(
                name: "BaseCountry",
                table: "Branches",
                newName: "baseCountry");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Branches",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Payee",
                table: "Branches",
                newName: "isPayee");

            migrationBuilder.RenameColumn(
                name: "BranchStatus",
                table: "Branches",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "BranchCode",
                table: "Branches",
                newName: "code");

            migrationBuilder.AddColumn<bool>(
                name: "commDiscountApprovalIsActive",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "commDiscountApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "commDiscountCpoApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "commDiscountParentApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "limit",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "maxAmountApproval",
                table: "Branches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "maxAmountApprovalIsActive",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "maxAmountApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "maxAmountCpoApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "maxAmountParentApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "maxCommApproval",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "maxCommApprovalIsActive",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "maxCommApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "maxCommCpoApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "maxCommParentApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "minCommApproval",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "minCommApprovalIsActive",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "minCommApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "minCommCpoApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "minCommParentApprovalRequired",
                table: "Branches",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "commDiscountApprovalIsActive",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "commDiscountApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "commDiscountCpoApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "commDiscountParentApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "limit",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxAmountApproval",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxAmountApprovalIsActive",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxAmountApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxAmountCpoApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxAmountParentApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxCommApproval",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxCommApprovalIsActive",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxCommApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxCommCpoApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "maxCommParentApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "minCommApproval",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "minCommApprovalIsActive",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "minCommApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "minCommCpoApprovalRequired",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "minCommParentApprovalRequired",
                table: "Branches");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Branches",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "tmtCommForSendingStatus",
                table: "Branches",
                newName: "TmtCommForSendingStatus");

            migrationBuilder.RenameColumn(
                name: "tmtCommForSending",
                table: "Branches",
                newName: "TmtCommForSending");

            migrationBuilder.RenameColumn(
                name: "telephone",
                table: "Branches",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "referenceBranch",
                table: "Branches",
                newName: "ReferenceBranch");

            migrationBuilder.RenameColumn(
                name: "parentBranch",
                table: "Branches",
                newName: "ParentBranch");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Branches",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "mmtCommForSendingStatus",
                table: "Branches",
                newName: "MmtCommForSendingStatus");

            migrationBuilder.RenameColumn(
                name: "mmtCommForSending",
                table: "Branches",
                newName: "MmtCommForSending");

            migrationBuilder.RenameColumn(
                name: "fax",
                table: "Branches",
                newName: "Fax");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Branches",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "domain",
                table: "Branches",
                newName: "Domain");

            migrationBuilder.RenameColumn(
                name: "createdon",
                table: "Branches",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "createdby",
                table: "Branches",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Branches",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "commForPayingBranchStatus",
                table: "Branches",
                newName: "CommForPayingBranchStatus");

            migrationBuilder.RenameColumn(
                name: "commForPayingBranch",
                table: "Branches",
                newName: "CommForPayingBranch");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Branches",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "canReceiveTMTFromPartner",
                table: "Branches",
                newName: "CanReceiveTMTFromPartner");

            migrationBuilder.RenameColumn(
                name: "canReceiveFromMMT",
                table: "Branches",
                newName: "CanReceiveFromMMT");

            migrationBuilder.RenameColumn(
                name: "baseCountry",
                table: "Branches",
                newName: "BaseCountry");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Branches",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "isPayee",
                table: "Branches",
                newName: "Payee");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Branches",
                newName: "BranchStatus");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "Branches",
                newName: "BranchCode");
        }
    }
}
