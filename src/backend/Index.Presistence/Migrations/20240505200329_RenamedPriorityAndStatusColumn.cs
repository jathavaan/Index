using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class RenamedPriorityAndStatusColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AssignmentStatus",
                schema: "sub",
                table: "Assignments",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "AssignmentPriority",
                schema: "sub",
                table: "Assignments",
                newName: "Priority");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 154, DateTimeKind.Local).AddTicks(5131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 709, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 153, DateTimeKind.Local).AddTicks(3336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 707, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 153, DateTimeKind.Local).AddTicks(7006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 708, DateTimeKind.Local).AddTicks(2079));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                schema: "sub",
                table: "Assignments",
                newName: "AssignmentStatus");

            migrationBuilder.RenameColumn(
                name: "Priority",
                schema: "sub",
                table: "Assignments",
                newName: "AssignmentPriority");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 709, DateTimeKind.Local).AddTicks(493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 154, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 707, DateTimeKind.Local).AddTicks(8385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 153, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 0, 9, 50, 708, DateTimeKind.Local).AddTicks(2079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 153, DateTimeKind.Local).AddTicks(7006));
        }
    }
}
