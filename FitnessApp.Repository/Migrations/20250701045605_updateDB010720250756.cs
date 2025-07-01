using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updateDB010720250756 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ActivityMembershipPlan",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "int", nullable: false),
                    MembershipPlansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityMembershipPlan", x => new { x.ActivitiesId, x.MembershipPlansId });
                    table.ForeignKey(
                        name: "FK_ActivityMembershipPlan_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityMembershipPlan_MembershipPlans_MembershipPlansId",
                        column: x => x.MembershipPlansId,
                        principalTable: "MembershipPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityMembershipPlan_MembershipPlansId",
                table: "ActivityMembershipPlan",
                column: "MembershipPlansId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityMembershipPlan");

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
    }
}
