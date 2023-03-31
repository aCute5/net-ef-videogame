﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_ef_videogame.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "softwarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IVA = table.Column<long>(type: "bigint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_softwarehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videogame",
                columns: table => new
                {
                    VideogameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftwareHouse_id = table.Column<int>(type: "int", nullable: false),
                    SoftwareHouseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videogame", x => x.VideogameId);
                    table.ForeignKey(
                        name: "FK_Videogame_softwarehouses_SoftwareHouseId",
                        column: x => x.SoftwareHouseId,
                        principalTable: "softwarehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_softwarehouses_Id",
                table: "softwarehouses",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Videogame_SoftwareHouseId",
                table: "Videogame",
                column: "SoftwareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Videogame_VideogameId",
                table: "Videogame",
                column: "VideogameId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Videogame");

            migrationBuilder.DropTable(
                name: "softwarehouses");
        }
    }
}
