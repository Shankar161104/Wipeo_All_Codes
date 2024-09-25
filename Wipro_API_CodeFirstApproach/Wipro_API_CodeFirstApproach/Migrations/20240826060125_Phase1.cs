﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wipro_API_CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class Phase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleRegistNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleBrandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleManufactureYear = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    VehiclePrice = table.Column<int>(type: "int", nullable: false),
                    VehicleColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleMileage = table.Column<int>(type: "int", nullable: false),
                    VehicleDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
