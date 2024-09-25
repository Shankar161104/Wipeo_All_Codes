using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Music_Library.Migrations
{
    /// <inheritdoc />
    public partial class Music3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Optional: If you need to retain data, create a temporary table or perform data migration here.

            // Adding a new column 'ArtistID'
            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            // If data migration is necessary, perform the data transfer before dropping the old column.

            // Dropping the old column 'Artist'
            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Songs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Recreate the 'Artist' column in case you need to roll back the migration
            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            // Optional: If you need to retain data, restore it here before dropping 'ArtistID'.

            // Dropping the new column 'ArtistID'
            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "Songs");
        }
    }
}
