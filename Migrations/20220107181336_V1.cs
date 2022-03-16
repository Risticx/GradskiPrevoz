using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProjekat.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Radnici",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadnoMesto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MatBr = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnici", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Zona",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojZone = table.Column<int>(type: "int", nullable: false),
                    NazivZone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CenaKarte = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zona", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Autobusi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistarskaOznaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kilometraza = table.Column<int>(type: "int", nullable: false),
                    RadnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autobusi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Autobusi_Radnici_RadnikId",
                        column: x => x.RadnikId,
                        principalTable: "Radnici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Karte",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojKarte = table.Column<int>(type: "int", nullable: false),
                    VremeIzdavanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CenaKarte = table.Column<int>(type: "int", nullable: false),
                    RadnikID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karte", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Karte_Radnici_RadnikID",
                        column: x => x.RadnikID,
                        principalTable: "Radnici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Linjia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojLinije = table.Column<int>(type: "int", nullable: false),
                    NazivLinije = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DuzinaLinije = table.Column<int>(type: "int", nullable: false),
                    VremeObilaska = table.Column<int>(type: "int", nullable: false),
                    ZonaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linjia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Linjia_Zona_ZonaID",
                        column: x => x.ZonaID,
                        principalTable: "Zona",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AutobusiLinija",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DanVoznje = table.Column<DateTime>(type: "date", nullable: false),
                    AutobusID = table.Column<int>(type: "int", nullable: true),
                    LinijaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutobusiLinija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AutobusiLinija_Autobusi_AutobusID",
                        column: x => x.AutobusID,
                        principalTable: "Autobusi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutobusiLinija_Linjia_LinijaID",
                        column: x => x.LinijaID,
                        principalTable: "Linjia",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autobusi_RadnikId",
                table: "Autobusi",
                column: "RadnikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AutobusiLinija_AutobusID",
                table: "AutobusiLinija",
                column: "AutobusID");

            migrationBuilder.CreateIndex(
                name: "IX_AutobusiLinija_LinijaID",
                table: "AutobusiLinija",
                column: "LinijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Karte_RadnikID",
                table: "Karte",
                column: "RadnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Linjia_ZonaID",
                table: "Linjia",
                column: "ZonaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutobusiLinija");

            migrationBuilder.DropTable(
                name: "Karte");

            migrationBuilder.DropTable(
                name: "Autobusi");

            migrationBuilder.DropTable(
                name: "Linjia");

            migrationBuilder.DropTable(
                name: "Radnici");

            migrationBuilder.DropTable(
                name: "Zona");
        }
    }
}
