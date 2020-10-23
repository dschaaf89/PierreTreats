using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PierreTreats.Migrations
{
    public partial class Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flavors",
                columns: table => new
                {
                    FlavorId = table.Column<string>(nullable: false),
                    FlavorType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flavors", x => x.FlavorId);
                });

            migrationBuilder.CreateTable(
                name: "Treats",
                columns: table => new
                {
                    TreatId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treats", x => x.TreatId);
                });

            migrationBuilder.CreateTable(
                name: "TreatFlavors",
                columns: table => new
                {
                    TreatFlavorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TreatId = table.Column<int>(nullable: false),
                    FlavorId = table.Column<int>(nullable: false),
                    TreatId1 = table.Column<string>(nullable: true),
                    FlavorId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatFlavors", x => x.TreatFlavorId);
                    table.ForeignKey(
                        name: "FK_TreatFlavors_Flavors_FlavorId1",
                        column: x => x.FlavorId1,
                        principalTable: "Flavors",
                        principalColumn: "FlavorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TreatFlavors_Treats_TreatId1",
                        column: x => x.TreatId1,
                        principalTable: "Treats",
                        principalColumn: "TreatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TreatFlavors_FlavorId1",
                table: "TreatFlavors",
                column: "FlavorId1");

            migrationBuilder.CreateIndex(
                name: "IX_TreatFlavors_TreatId1",
                table: "TreatFlavors",
                column: "TreatId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TreatFlavors");

            migrationBuilder.DropTable(
                name: "Flavors");

            migrationBuilder.DropTable(
                name: "Treats");
        }
    }
}
