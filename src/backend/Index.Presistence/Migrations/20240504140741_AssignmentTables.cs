using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class AssignmentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.RenameColumn(
                name: "Credit",
                schema: "sub",
                table: "Subject",
                newName: "Credits");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 125, DateTimeKind.Local).AddTicks(7302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 12, 16, 49, 306, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject",
                columns: new[] { "ReportCardId", "SubjectCode", "Year" });

            migrationBuilder.CreateTable(
                name: "AssignmentGroup",
                schema: "sub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 124, DateTimeKind.Local).AddTicks(8920)),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAssignments = table.Column<int>(type: "int", nullable: false),
                    UserProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssignmentGroup_Subject_SubjectCode",
                        column: x => x.SubjectCode,
                        principalSchema: "sub",
                        principalTable: "Subject",
                        principalColumn: "SubjectCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentGroup_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                schema: "sub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 124, DateTimeKind.Local).AddTicks(5467)),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignmentPriority = table.Column<int>(type: "int", nullable: false),
                    AssignmentStatus = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignmentGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignment_AssignmentGroup_AssignmentGroupId",
                        column: x => x.AssignmentGroupId,
                        principalSchema: "sub",
                        principalTable: "AssignmentGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "sub",
                table: "Subject",
                columns: new[] { "SubjectCode", "Credits", "Name" },
                values: new object[] { "TMA4240", 7.5, "Statistics" });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_AssignmentGroupId",
                schema: "sub",
                table: "Assignment",
                column: "AssignmentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentGroup_SubjectCode",
                schema: "sub",
                table: "AssignmentGroup",
                column: "SubjectCode");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentGroup_UserProfileId",
                schema: "sub",
                table: "AssignmentGroup",
                column: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignment",
                schema: "sub");

            migrationBuilder.DropTable(
                name: "AssignmentGroup",
                schema: "sub");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DeleteData(
                schema: "sub",
                table: "Subject",
                keyColumn: "SubjectCode",
                keyValue: "TMA4240");

            migrationBuilder.DropColumn(
                name: "Year",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.DropColumn(
                name: "Semester",
                schema: "sub",
                table: "ReportCardSubject");

            migrationBuilder.RenameColumn(
                name: "Credits",
                schema: "sub",
                table: "Subject",
                newName: "Credit");

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
                defaultValue: new DateTime(2024, 5, 4, 12, 16, 49, 306, DateTimeKind.Local).AddTicks(1599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 125, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject",
                columns: new[] { "ReportCardId", "SubjectCode" });
        }
    }
}
