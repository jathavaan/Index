using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class RemovedSubjectIdFromSubjectEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [sub].[ReportCardSubject]");
            migrationBuilder.Sql("DELETE FROM [sub].[Subject]");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportCardSubject_Subject_SubjectId",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                schema: "sub",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DropIndex(
                name: "IX_ReportCardSubject_SubjectId",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 25);

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "sub",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.AddColumn<string>(
                name: "SubjectCode",
                schema: "sub",
                table: "ReportCardSubject",
                type: "nvarchar(8)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 12, 16, 49, 306, DateTimeKind.Local).AddTicks(1599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 28, 21, 29, 20, 340, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                schema: "sub",
                table: "Subject",
                column: "SubjectCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject",
                columns: new[] { "ReportCardId", "SubjectCode" });

            migrationBuilder.InsertData(
                schema: "sub",
                table: "Subject",
                columns: new[] { "SubjectCode", "Credit", "Name" },
                values: new object[,]
                {
                    { "EXPH0300", 7.5, "Examen philosophicum for Science and Technology" },
                    { "HMS0002", 0.0, "Health, Safety and Environment (HSE) course for 1st year students" },
                    { "IT2805", 7.5, "Web Technologies" },
                    { "TBA4231", 7.5, "Applied Geomatics" },
                    { "TBA4236", 7.5, "Theoretical Geomatics" },
                    { "TBA4240", 7.5, "Geographic Information Handling 1, Basic Course" },
                    { "TBA4250", 7.5, "Geographic Information Handling 2, Basic Course" },
                    { "TBA4251", 7.5, "Programming in Geomatics" },
                    { "TBA4256", 7.5, "3D Digital Modelling" },
                    { "TDT4100", 7.5, "Object-Oriented Programming" },
                    { "TDT4110", 7.5, "Information Technology, Introduction" },
                    { "TDT4120", 7.5, "Algorithms and Data Structures" },
                    { "TDT4140", 7.5, "Software Engineering" },
                    { "TDT4145", 7.5, "Data Modelling, Databases, and Database Management Systems" },
                    { "TDT4173", 7.5, "Machine Learning" },
                    { "TEP4100", 7.5, "Fluid Mechanics" },
                    { "TEP4225", 7.5, "Energy and Environment" },
                    { "TFY4115", 7.5, "Physics" },
                    { "TKT4116", 7.5, "Mechanics 1" },
                    { "TKT4122", 7.5, "Mechanics 2" },
                    { "TMA4100", 7.5, "Calculus 1" },
                    { "TMA4105", 7.5, "Calculus 2" },
                    { "TMA4115", 7.5, "Mathematics 3 - Linear Algebra" },
                    { "TMA4130", 7.5, "Mathematics 4N - Differential Equations and Fourier Analysis" },
                    { "TMA4140", 7.5, "Discrete Mathematics" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportCardSubject_SubjectCode",
                schema: "sub",
                table: "ReportCardSubject",
                column: "SubjectCode");

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCardSubject_Subject_SubjectCode",
                schema: "sub",
                table: "ReportCardSubject",
                column: "SubjectCode",
                principalSchema: "sub",
                principalTable: "Subject",
                principalColumn: "SubjectCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportCardSubject_Subject_SubjectCode",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                schema: "sub",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DropIndex(
                name: "IX_ReportCardSubject_SubjectCode",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "EXPH0300");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "HMS0002");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "IT2805");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TBA4231");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TBA4236");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TBA4240");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TBA4250");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TBA4251");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TBA4256");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TDT4100");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TDT4110");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TDT4120");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TDT4140");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TDT4145");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TDT4173");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TEP4100");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TEP4225");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TFY4115");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TKT4116");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TKT4122");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TMA4100");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TMA4105");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TMA4115");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TMA4130");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TMA4140");

            migrationBuilder.DropColumn(
                name: "SubjectCode",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "sub",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
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
                defaultValue: new DateTime(2024, 4, 28, 21, 29, 20, 340, DateTimeKind.Local).AddTicks(9814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 12, 16, 49, 306, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                schema: "sub",
                table: "Subject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject",
                columns: new[] { "ReportCardId", "SubjectId" });

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

            migrationBuilder.CreateIndex(
                name: "IX_ReportCardSubject_SubjectId",
                schema: "sub",
                table: "ReportCardSubject",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCardSubject_Subject_SubjectId",
                schema: "sub",
                table: "ReportCardSubject",
                column: "SubjectId",
                principalSchema: "sub",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
