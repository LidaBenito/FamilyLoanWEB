using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyLoan.Infra.Data.Sql.Migrations
{
    public partial class addassemplyoncontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Accounts_AccountID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_AccountID",
                table: "People");

            migrationBuilder.EnsureSchema(
                name: "FamilyLoan");

            migrationBuilder.RenameTable(
                name: "Profits",
                newName: "Profits",
                newSchema: "FamilyLoan");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "People",
                newSchema: "FamilyLoan");

            migrationBuilder.RenameTable(
                name: "Loans",
                newName: "Loans",
                newSchema: "FamilyLoan");

            migrationBuilder.RenameTable(
                name: "LoanItems",
                newName: "LoanItems",
                newSchema: "FamilyLoan");

            migrationBuilder.RenameTable(
                name: "Banks",
                newName: "Banks",
                newSchema: "FamilyLoan");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Accounts",
                newSchema: "FamilyLoan");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                schema: "FamilyLoan",
                table: "People",
                newName: "AccountIDNo");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "FamilyLoan",
                table: "Profits",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                schema: "FamilyLoan",
                table: "People",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "FamilyLoan",
                table: "People",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                schema: "FamilyLoan",
                table: "People",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                schema: "FamilyLoan",
                table: "People",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "FamilyLoan",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "FamilyLoan",
                table: "Banks",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "FamilyLoan",
                table: "Accounts",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "personID",
                schema: "FamilyLoan",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_personID",
                schema: "FamilyLoan",
                table: "Accounts",
                column: "personID");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_People_personID",
                schema: "FamilyLoan",
                table: "Accounts",
                column: "personID",
                principalSchema: "FamilyLoan",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_People_personID",
                schema: "FamilyLoan",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_personID",
                schema: "FamilyLoan",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "FamilyLoan",
                table: "People");

            migrationBuilder.DropColumn(
                name: "personID",
                schema: "FamilyLoan",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "Profits",
                schema: "FamilyLoan",
                newName: "Profits");

            migrationBuilder.RenameTable(
                name: "People",
                schema: "FamilyLoan",
                newName: "People");

            migrationBuilder.RenameTable(
                name: "Loans",
                schema: "FamilyLoan",
                newName: "Loans");

            migrationBuilder.RenameTable(
                name: "LoanItems",
                schema: "FamilyLoan",
                newName: "LoanItems");

            migrationBuilder.RenameTable(
                name: "Banks",
                schema: "FamilyLoan",
                newName: "Banks");

            migrationBuilder.RenameTable(
                name: "Accounts",
                schema: "FamilyLoan",
                newName: "Accounts");

            migrationBuilder.RenameColumn(
                name: "AccountIDNo",
                table: "People",
                newName: "AccountID");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Profits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Banks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_AccountID",
                table: "People",
                column: "AccountID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Accounts_AccountID",
                table: "People",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
