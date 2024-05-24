using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDateTimeNowFromEntityConfiguration : Migration
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
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 972, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(690));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(8747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 972, DateTimeKind.Local).AddTicks(7319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
