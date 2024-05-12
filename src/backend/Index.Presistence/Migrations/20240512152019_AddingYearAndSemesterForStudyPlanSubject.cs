using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class AddingYearAndSemesterForStudyPlanSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Semester",
                schema: "sub",
                table: "StudyPlanSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                schema: "sub",
                table: "StudyPlanSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(8747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 621, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 972, DateTimeKind.Local).AddTicks(7319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 619, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 620, DateTimeKind.Local).AddTicks(3211));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semester",
                schema: "sub",
                table: "StudyPlanSubjects");

            migrationBuilder.DropColumn(
                name: "Year",
                schema: "sub",
                table: "StudyPlanSubjects");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 621, DateTimeKind.Local).AddTicks(2890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 619, DateTimeKind.Local).AddTicks(9301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 972, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 45, 31, 620, DateTimeKind.Local).AddTicks(3211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(690));
        }
    }
}
