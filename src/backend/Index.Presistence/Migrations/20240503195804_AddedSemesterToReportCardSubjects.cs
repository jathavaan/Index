using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedSemesterToReportCardSubjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                schema: "sub",
                table: "ReportCardSubject",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                schema: "sub",
                table: "ReportCardSubject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Semester",
                schema: "sub",
                table: "ReportCardSubject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 3, 21, 58, 4, 277, DateTimeKind.Local).AddTicks(8052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 28, 21, 29, 20, 340, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject",
                columns: new[] { "ReportCardId", "SubjectId", "Year" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DropColumn(
                name: "Year",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DropColumn(
                name: "Semester",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                schema: "sub",
                table: "ReportCardSubject",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 28, 21, 29, 20, 340, DateTimeKind.Local).AddTicks(9814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 3, 21, 58, 4, 277, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject",
                columns: new[] { "ReportCardId", "SubjectId" });
        }
    }
}
