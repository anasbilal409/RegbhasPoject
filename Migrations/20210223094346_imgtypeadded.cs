using Microsoft.EntityFrameworkCore.Migrations;

namespace Regbhas.Migrations
{
    public partial class imgtypeadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_ProjectCategory_CategoryId",
                table: "Project");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ImgTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImgTypes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Project_ProjectCategory_CategoryId",
                table: "Project",
                column: "CategoryId",
                principalTable: "ProjectCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_ProjectCategory_CategoryId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "ImgTypes");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Project",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_ProjectCategory_CategoryId",
                table: "Project",
                column: "CategoryId",
                principalTable: "ProjectCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
