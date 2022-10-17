using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP02.Migrations
{
    public partial class TP_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Container_BL_BLNumero",
                table: "Container");

            migrationBuilder.RenameColumn(
                name: "BLNumero",
                table: "Container",
                newName: "Container");

            migrationBuilder.RenameIndex(
                name: "IX_Container_BLNumero",
                table: "Container",
                newName: "IX_Container_Container");

            migrationBuilder.AddForeignKey(
                name: "FK_Container_BL_Container",
                table: "Container",
                column: "Container",
                principalTable: "BL",
                principalColumn: "Numero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Container_BL_Container",
                table: "Container");

            migrationBuilder.RenameColumn(
                name: "Container",
                table: "Container",
                newName: "BLNumero");

            migrationBuilder.RenameIndex(
                name: "IX_Container_Container",
                table: "Container",
                newName: "IX_Container_BLNumero");

            migrationBuilder.AddForeignKey(
                name: "FK_Container_BL_BLNumero",
                table: "Container",
                column: "BLNumero",
                principalTable: "BL",
                principalColumn: "Numero");
        }
    }
}
