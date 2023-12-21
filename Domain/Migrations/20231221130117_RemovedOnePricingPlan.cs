using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class RemovedOnePricingPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PricingPlans",
                keyColumn: "Id",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PricingPlans",
                columns: new[] { "Id", "DailyPricing", "HourlyPricing", "MinimumHours", "PricingPlanTypeId" },
                values: new object[] { 3, 30.0, 1.5, 12, 1 });
        }
    }
}
