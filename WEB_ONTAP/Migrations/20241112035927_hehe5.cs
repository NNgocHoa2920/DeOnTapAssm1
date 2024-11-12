using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_ONTAP.Migrations
{
    /// <inheritdoc />
    public partial class hehe5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DACTs_DuAns_DuAnID",
                table: "DACTs");

            migrationBuilder.AlterColumn<string>(
                name: "DuAnID",
                table: "DACTs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_DACTs_DuAns_DuAnID",
                table: "DACTs",
                column: "DuAnID",
                principalTable: "DuAns",
                principalColumn: "MaDA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DACTs_DuAns_DuAnID",
                table: "DACTs");

            migrationBuilder.AlterColumn<string>(
                name: "DuAnID",
                table: "DACTs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DACTs_DuAns_DuAnID",
                table: "DACTs",
                column: "DuAnID",
                principalTable: "DuAns",
                principalColumn: "MaDA",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
