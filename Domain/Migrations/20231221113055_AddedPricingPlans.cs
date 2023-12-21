using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class AddedPricingPlans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ParkingPlans",
                columns: new[] { "Id", "DailyPricing", "HourlyPricing", "MinimumHours", "PricingPlanTypeId" },
                values: new object[] { 1, 40.0, 2.0, 10, 2 });

            migrationBuilder.InsertData(
                table: "ParkingPlans",
                columns: new[] { "Id", "DailyPricing", "HourlyPricing", "MinimumHours", "PricingPlanTypeId" },
                values: new object[] { 2, 20.0, 1.0, 5, 1 });

            migrationBuilder.InsertData(
                table: "ParkingPlans",
                columns: new[] { "Id", "DailyPricing", "HourlyPricing", "MinimumHours", "PricingPlanTypeId" },
                values: new object[] { 3, 30.0, 1.5, 12, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParkingPlans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkingPlans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkingPlans",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
