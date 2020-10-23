using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PierreTreats.Migrations
{
    public partial class fixTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavors_Flavors_FlavorId1",
                table: "TreatFlavors");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavors_Treats_TreatId1",
                table: "TreatFlavors");

            migrationBuilder.DropIndex(
                name: "IX_TreatFlavors_FlavorId1",
                table: "TreatFlavors");

            migrationBuilder.DropIndex(
                name: "IX_TreatFlavors_TreatId1",
                table: "TreatFlavors");

            migrationBuilder.DropColumn(
                name: "FlavorId1",
                table: "TreatFlavors");

            migrationBuilder.DropColumn(
                name: "TreatId1",
                table: "TreatFlavors");

            migrationBuilder.AlterColumn<int>(
                name: "TreatId",
                table: "Treats",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "FlavorId",
                table: "Flavors",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_TreatFlavors_FlavorId",
                table: "TreatFlavors",
                column: "FlavorId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatFlavors_TreatId",
                table: "TreatFlavors",
                column: "TreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavors_Flavors_FlavorId",
                table: "TreatFlavors",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavors_Treats_TreatId",
                table: "TreatFlavors",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavors_Flavors_FlavorId",
                table: "TreatFlavors");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavors_Treats_TreatId",
                table: "TreatFlavors");

            migrationBuilder.DropIndex(
                name: "IX_TreatFlavors_FlavorId",
                table: "TreatFlavors");

            migrationBuilder.DropIndex(
                name: "IX_TreatFlavors_TreatId",
                table: "TreatFlavors");

            migrationBuilder.AlterColumn<string>(
                name: "TreatId",
                table: "Treats",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "FlavorId1",
                table: "TreatFlavors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TreatId1",
                table: "TreatFlavors",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FlavorId",
                table: "Flavors",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_TreatFlavors_FlavorId1",
                table: "TreatFlavors",
                column: "FlavorId1");

            migrationBuilder.CreateIndex(
                name: "IX_TreatFlavors_TreatId1",
                table: "TreatFlavors",
                column: "TreatId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavors_Flavors_FlavorId1",
                table: "TreatFlavors",
                column: "FlavorId1",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavors_Treats_TreatId1",
                table: "TreatFlavors",
                column: "TreatId1",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
