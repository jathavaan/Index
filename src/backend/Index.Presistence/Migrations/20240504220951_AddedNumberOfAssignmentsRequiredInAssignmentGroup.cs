using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedNumberOfAssignmentsRequiredInAssignmentGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 709, DateTimeKind.Local).AddTicks(493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 712, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 707, DateTimeKind.Local).AddTicks(8385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 711, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 708, DateTimeKind.Local).AddTicks(2079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 711, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.AddColumn<int>(
                name: "AssignmentsRequired",
                schema: "sub",
                table: "AssignmentGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignmentsRequired",
                schema: "sub",
                table: "AssignmentGroups");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 712, DateTimeKind.Local).AddTicks(7150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 709, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 711, DateTimeKind.Local).AddTicks(1303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 707, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 711, DateTimeKind.Local).AddTicks(5029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 708, DateTimeKind.Local).AddTicks(2079));
        }
    }
}
