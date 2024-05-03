using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class ReportCardForeignKeySwitch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportCardSubject_ReportCard_SubjectId",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 28, 15, 16, 39, 680, DateTimeKind.Local).AddTicks(6534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 12, 17, 7, 50, 290, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCardSubject_ReportCard_ReportCardId",
                schema: "sub",
                table: "ReportCardSubject",
                column: "ReportCardId",
                principalSchema: "sub",
                principalTable: "ReportCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportCardSubject_ReportCard_ReportCardId",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 12, 17, 7, 50, 290, DateTimeKind.Local).AddTicks(7625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 28, 15, 16, 39, 680, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCardSubject_ReportCard_SubjectId",
                schema: "sub",
                table: "ReportCardSubject",
                column: "SubjectId",
                principalSchema: "sub",
                principalTable: "ReportCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
