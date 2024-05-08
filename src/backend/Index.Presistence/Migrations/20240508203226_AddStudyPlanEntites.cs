using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class AddStudyPlanEntites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportCardSubjects_Subjects_SubjectCode",
                schema: "sub",
                table: "ReportCardSubjects");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                schema: "sub",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 979, DateTimeKind.Local).AddTicks(3447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 154, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 977, DateTimeKind.Local).AddTicks(6853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 153, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 978, DateTimeKind.Local).AddTicks(1992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 153, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.CreateTable(
                name: "StudyPlans",
                schema: "sub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyPlans_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyPlanRestriction",
                schema: "sub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectType = table.Column<int>(type: "int", nullable: false),
                    RequiredCredits = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    StudyPlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyPlanRestriction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyPlanRestriction_StudyPlans_StudyPlanId",
                        column: x => x.StudyPlanId,
                        principalSchema: "sub",
                        principalTable: "StudyPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudyPlanSubjects",
                schema: "sub",
                columns: table => new
                {
                    StudyPlanId = table.Column<int>(type: "int", nullable: false),
                    SubjectCode = table.Column<string>(type: "nvarchar(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyPlanSubjects", x => new { x.SubjectCode, x.StudyPlanId });
                    table.ForeignKey(
                        name: "FK_StudyPlanSubjects_StudyPlans_StudyPlanId",
                        column: x => x.StudyPlanId,
                        principalSchema: "sub",
                        principalTable: "StudyPlans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudyPlanSubjects_Subjects_SubjectCode",
                        column: x => x.SubjectCode,
                        principalSchema: "sub",
                        principalTable: "Subjects",
                        principalColumn: "SubjectCode");
                });

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "EXPH0300",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "HMS0002",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "IT2805",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TBA4231",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TBA4236",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TBA4240",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TBA4250",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TBA4251",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TBA4256",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TDT4100",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TDT4110",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TDT4120",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TDT4140",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TDT4145",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TDT4173",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TEP4100",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TEP4225",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TFY4115",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TKT4116",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TKT4122",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TMA4100",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TMA4105",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TMA4115",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TMA4130",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TMA4140",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "sub",
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "TMA4240",
                column: "Type",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudyPlanRestriction_StudyPlanId",
                schema: "sub",
                table: "StudyPlanRestriction",
                column: "StudyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyPlans_UserProfileId",
                schema: "sub",
                table: "StudyPlans",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyPlanSubjects_StudyPlanId",
                schema: "sub",
                table: "StudyPlanSubjects",
                column: "StudyPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCardSubjects_Subjects_SubjectCode",
                schema: "sub",
                table: "ReportCardSubjects",
                column: "SubjectCode",
                principalSchema: "sub",
                principalTable: "Subjects",
                principalColumn: "SubjectCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportCardSubjects_Subjects_SubjectCode",
                schema: "sub",
                table: "ReportCardSubjects");

            migrationBuilder.DropTable(
                name: "StudyPlanRestriction",
                schema: "sub");

            migrationBuilder.DropTable(
                name: "StudyPlanSubjects",
                schema: "sub");

            migrationBuilder.DropTable(
                name: "StudyPlans",
                schema: "sub");

            migrationBuilder.DropColumn(
                name: "Type",
                schema: "sub",
                table: "Subjects");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 154, DateTimeKind.Local).AddTicks(5131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 979, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 153, DateTimeKind.Local).AddTicks(3336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 977, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 22, 3, 29, 153, DateTimeKind.Local).AddTicks(7006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 22, 32, 25, 978, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCardSubjects_Subjects_SubjectCode",
                schema: "sub",
                table: "ReportCardSubjects",
                column: "SubjectCode",
                principalSchema: "sub",
                principalTable: "Subjects",
                principalColumn: "SubjectCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
