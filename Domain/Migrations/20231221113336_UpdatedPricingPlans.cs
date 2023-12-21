using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class UpdatedPricingPlans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkingPlans_PricingPlanTypes_PricingPlanTypeId",
                table: "ParkingPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkingPlans",
                table: "ParkingPlans");

            migrationBuilder.RenameTable(
                name: "ParkingPlans",
                newName: "PricingPlans");

            migrationBuilder.RenameIndex(
                name: "IX_ParkingPlans_PricingPlanTypeId",
                table: "PricingPlans",
                newName: "IX_PricingPlans_PricingPlanTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PricingPlans",
                table: "PricingPlans",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PricingPlans_PricingPlanTypes_PricingPlanTypeId",
                table: "PricingPlans",
                column: "PricingPlanTypeId",
                principalTable: "PricingPlanTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PricingPlans_PricingPlanTypes_PricingPlanTypeId",
                table: "PricingPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PricingPlans",
                table: "PricingPlans");

            migrationBuilder.RenameTable(
                name: "PricingPlans",
                newName: "ParkingPlans");

            migrationBuilder.RenameIndex(
                name: "IX_PricingPlans_PricingPlanTypeId",
                table: "ParkingPlans",
                newName: "IX_ParkingPlans_PricingPlanTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkingPlans",
                table: "ParkingPlans",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingPlans_PricingPlanTypes_PricingPlanTypeId",
                table: "ParkingPlans",
                column: "PricingPlanTypeId",
                principalTable: "PricingPlanTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
