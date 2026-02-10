using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_core.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_studentable",
                table: "studentable");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "studentable",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "studentable",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "studentable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "studentable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentable",
                table: "studentable",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_studentable",
                table: "studentable");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "studentable");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "studentable");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "studentable");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "studentable",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentable",
                table: "studentable",
                column: "Name");
        }
    }
}
