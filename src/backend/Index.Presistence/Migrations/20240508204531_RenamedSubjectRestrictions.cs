using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class RenamedSubjectRestrictions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyPlanRestriction_StudyPlans_StudyPlanId",
                schema: "sub",
                table: "StudyPlanRestriction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudyPlanRestriction",
                schema: "sub",
                table: "StudyPlanRestriction");

            migrationBuilder.RenameTable(
                name: "StudyPlanRestriction",
                schema: "sub",
                newName: "StudyPlanRestrictions",
                newSchema: "sub");

            migrationBuilder.RenameIndex(
                name: "IX_StudyPlanRestriction_StudyPlanId",
                schema: "sub",
                table: "StudyPlanRestrictions",
                newName: "IX_StudyPlanRestrictions_StudyPlanId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 621, DateTimeKind.Local).AddTicks(2890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 979, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 619, DateTimeKind.Local).AddTicks(9301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 977, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 620, DateTimeKind.Local).AddTicks(3211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 978, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudyPlanRestrictions",
                schema: "sub",
                table: "StudyPlanRestrictions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyPlanRestrictions_StudyPlans_StudyPlanId",
                schema: "sub",
                table: "StudyPlanRestrictions",
                column: "StudyPlanId",
                principalSchema: "sub",
                principalTable: "StudyPlans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyPlanRestrictions_StudyPlans_StudyPlanId",
                schema: "sub",
                table: "StudyPlanRestrictions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudyPlanRestrictions",
                schema: "sub",
                table: "StudyPlanRestrictions");

            migrationBuilder.RenameTable(
                name: "StudyPlanRestrictions",
                schema: "sub",
                newName: "StudyPlanRestriction",
                newSchema: "sub");

            migrationBuilder.RenameIndex(
                name: "IX_StudyPlanRestrictions_StudyPlanId",
                schema: "sub",
                table: "StudyPlanRestriction",
                newName: "IX_StudyPlanRestriction_StudyPlanId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 979, DateTimeKind.Local).AddTicks(3447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 621, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 977, DateTimeKind.Local).AddTicks(6853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 619, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 978, DateTimeKind.Local).AddTicks(1992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 620, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudyPlanRestriction",
                schema: "sub",
                table: "StudyPlanRestriction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyPlanRestriction_StudyPlans_StudyPlanId",
                schema: "sub",
                table: "StudyPlanRestriction",
                column: "StudyPlanId",
                principalSchema: "sub",
                principalTable: "StudyPlans",
                principalColumn: "Id");
        }
    }
}
