using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Music_Library.Migrations
{
    public partial class Music5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop Users1 table if it exists
            migrationBuilder.DropTable(
                name: "Users1");

            // No need to recreate Identity tables if they already exist
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Recreate Users1 table if needed for rollback purposes
            migrationBuilder.CreateTable(
                name: "Users1",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users1", x => x.UserID);
                });
        }
    }
}
