using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.netCoreMVCCRUD.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "Employees",
                newName: "Fullname");

            migrationBuilder.RenameColumn(
                name: "varchar(150)",
                table: "Employees",
                newName: "EmpCode");

            migrationBuilder.AlterColumn<string>(
                name: "Fullname",
                table: "Employees",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EmpCode",
                table: "Employees",
                type: "varchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeLocation",
                table: "Employees",
                type: "varchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Employees",
                type: "varchar(150)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfficeLocation",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Employees",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "EmpCode",
                table: "Employees",
                newName: "varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(150)",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldNullable: true);
        }
    }
}
