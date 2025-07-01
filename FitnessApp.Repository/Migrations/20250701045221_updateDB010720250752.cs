using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updateDB010720250752 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MembershipPlanId",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "MembershipPlanId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_MembershipPlanId",
                table: "Activities",
                column: "MembershipPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_MembershipPlans_MembershipPlanId",
                table: "Activities",
                column: "MembershipPlanId",
                principalTable: "MembershipPlans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_MembershipPlans_MembershipPlanId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_MembershipPlanId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "MembershipPlanId",
                table: "Activities");
        }
    }
}
