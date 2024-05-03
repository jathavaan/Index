using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class SubjectDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubjectCode",
                schema: "sub",
                table: "Subject",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 28, 21, 29, 20, 340, DateTimeKind.Local).AddTicks(9814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 28, 15, 16, 39, 680, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.InsertData(
                schema: "sub",
                table: "Subject",
                columns: new[] { "Id", "Credit", "Name", "SubjectCode" },
                values: new object[,]
                {
                    { 1, 7.5, "Examen philosophicum for Science and Technology", "EXPH0300" },
                    { 2, 7.5, "Web Technologies", "IT2805" },
                    { 3, 7.5, "Applied Geomatics", "TBA4231" },
                    { 4, 7.5, "Theoretical Geomatics", "TBA4236" },
                    { 5, 7.5, "Geographic Information Handling 1, Basic Course", "TBA4240" },
                    { 6, 7.5, "Geographic Information Handling 2, Basic Course", "TBA4250" },
                    { 7, 7.5, "Programming in Geomatics", "TBA4251" },
                    { 8, 7.5, "3D Digital Modelling", "TBA4256" },
                    { 9, 7.5, "Physics", "TFY4115" },
                    { 10, 7.5, "Fluid Mechanics", "TEP4100" },
                    { 11, 7.5, "Energy and Environment", "TEP4225" },
                    { 12, 7.5, "Object-Oriented Programming", "TDT4100" },
                    { 13, 7.5, "Information Technology, Introduction", "TDT4110" },
                    { 14, 7.5, "Algorithms and Data Structures", "TDT4120" },
                    { 15, 7.5, "Software Engineering", "TDT4140" },
                    { 16, 7.5, "Data Modelling, Databases, and Database Management Systems", "TDT4145" },
                    { 17, 7.5, "Machine Learning", "TDT4173" },
                    { 18, 7.5, "Mechanics 1", "TKT4116" },
                    { 19, 7.5, "Mechanics 2", "TKT4122" },
                    { 20, 7.5, "Calculus 1", "TMA4100" },
                    { 21, 7.5, "Calculus 2", "TMA4105" },
                    { 22, 7.5, "Mathematics 3 - Linear Algebra", "TMA4115" },
                    { 23, 7.5, "Mathematics 4N - Differential Equations and Fourier Analysis", "TMA4130" },
                    { 24, 7.5, "Discrete Mathematics", "TMA4140" },
                    { 25, 0.0, "Health, Safety and Environment (HSE) course for 1st year students", "HMS0002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectCode",
                schema: "sub",
                table: "Subject",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 28, 15, 16, 39, 680, DateTimeKind.Local).AddTicks(6534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 28, 21, 29, 20, 340, DateTimeKind.Local).AddTicks(9814));
        }
    }
}
