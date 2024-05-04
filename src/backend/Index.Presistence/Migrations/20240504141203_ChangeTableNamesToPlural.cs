using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableNamesToPlural : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_AssignmentGroup_AssignmentGroupId",
                schema: "sub",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentGroup_Subject_SubjectCode",
                schema: "sub",
                table: "AssignmentGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentGroup_UserProfiles_UserProfileId",
                schema: "sub",
                table: "AssignmentGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportCard_UserProfiles_UserProfileId",
                schema: "sub",
                table: "ReportCard");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportCardSubject_ReportCard_ReportCardId",
                schema: "sub",
                table: "ReportCardSubject");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportCard",
                schema: "sub",
                table: "ReportCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignmentGroup",
                schema: "sub",
                table: "AssignmentGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignment",
                schema: "sub",
                table: "Assignment");

            migrationBuilder.RenameTable(
                name: "Subject",
                schema: "sub",
                newName: "Subjects",
                newSchema: "sub");

            migrationBuilder.RenameTable(
                name: "ReportCardSubject",
                schema: "sub",
                newName: "ReportCardSubjects",
                newSchema: "sub");

            migrationBuilder.RenameTable(
                name: "ReportCard",
                schema: "sub",
                newName: "ReportCards",
                newSchema: "sub");

            migrationBuilder.RenameTable(
                name: "AssignmentGroup",
                schema: "sub",
                newName: "AssignmentGroups",
                newSchema: "sub");

            migrationBuilder.RenameTable(
                name: "Assignment",
                schema: "sub",
                newName: "Assignments",
                newSchema: "sub");

            migrationBuilder.RenameIndex(
                name: "IX_ReportCardSubject_SubjectCode",
                schema: "sub",
                table: "ReportCardSubjects",
                newName: "IX_ReportCardSubjects_SubjectCode");

            migrationBuilder.RenameIndex(
                name: "IX_ReportCard_UserProfileId",
                schema: "sub",
                table: "ReportCards",
                newName: "IX_ReportCards_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentGroup_UserProfileId",
                schema: "sub",
                table: "AssignmentGroups",
                newName: "IX_AssignmentGroups_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentGroup_SubjectCode",
                schema: "sub",
                table: "AssignmentGroups",
                newName: "IX_AssignmentGroups_SubjectCode");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_AssignmentGroupId",
                schema: "sub",
                table: "Assignments",
                newName: "IX_Assignments_AssignmentGroupId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 712, DateTimeKind.Local).AddTicks(7150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 125, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 711, DateTimeKind.Local).AddTicks(5029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 124, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 711, DateTimeKind.Local).AddTicks(1303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 124, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                schema: "sub",
                table: "Subjects",
                column: "SubjectCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCardSubjects",
                schema: "sub",
                table: "ReportCardSubjects",
                columns: new[] { "ReportCardId", "SubjectCode", "Year" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCards",
                schema: "sub",
                table: "ReportCards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignmentGroups",
                schema: "sub",
                table: "AssignmentGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignments",
                schema: "sub",
                table: "Assignments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentGroups_Subjects_SubjectCode",
                schema: "sub",
                table: "AssignmentGroups",
                column: "SubjectCode",
                principalSchema: "sub",
                principalTable: "Subjects",
                principalColumn: "SubjectCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentGroups_UserProfiles_UserProfileId",
                schema: "sub",
                table: "AssignmentGroups",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_AssignmentGroups_AssignmentGroupId",
                schema: "sub",
                table: "Assignments",
                column: "AssignmentGroupId",
                principalSchema: "sub",
                principalTable: "AssignmentGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCards_UserProfiles_UserProfileId",
                schema: "sub",
                table: "ReportCards",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCardSubjects_ReportCards_ReportCardId",
                schema: "sub",
                table: "ReportCardSubjects",
                column: "ReportCardId",
                principalSchema: "sub",
                principalTable: "ReportCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentGroups_Subjects_SubjectCode",
                schema: "sub",
                table: "AssignmentGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentGroups_UserProfiles_UserProfileId",
                schema: "sub",
                table: "AssignmentGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_AssignmentGroups_AssignmentGroupId",
                schema: "sub",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportCards_UserProfiles_UserProfileId",
                schema: "sub",
                table: "ReportCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportCardSubjects_ReportCards_ReportCardId",
                schema: "sub",
                table: "ReportCardSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportCardSubjects_Subjects_SubjectCode",
                schema: "sub",
                table: "ReportCardSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                schema: "sub",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportCardSubjects",
                schema: "sub",
                table: "ReportCardSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportCards",
                schema: "sub",
                table: "ReportCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignments",
                schema: "sub",
                table: "Assignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignmentGroups",
                schema: "sub",
                table: "AssignmentGroups");

            migrationBuilder.RenameTable(
                name: "Subjects",
                schema: "sub",
                newName: "Subject",
                newSchema: "sub");

            migrationBuilder.RenameTable(
                name: "ReportCardSubjects",
                schema: "sub",
                newName: "ReportCardSubject",
                newSchema: "sub");

            migrationBuilder.RenameTable(
                name: "ReportCards",
                schema: "sub",
                newName: "ReportCard",
                newSchema: "sub");

            migrationBuilder.RenameTable(
                name: "Assignments",
                schema: "sub",
                newName: "Assignment",
                newSchema: "sub");

            migrationBuilder.RenameTable(
                name: "AssignmentGroups",
                schema: "sub",
                newName: "AssignmentGroup",
                newSchema: "sub");

            migrationBuilder.RenameIndex(
                name: "IX_ReportCardSubjects_SubjectCode",
                schema: "sub",
                table: "ReportCardSubject",
                newName: "IX_ReportCardSubject_SubjectCode");

            migrationBuilder.RenameIndex(
                name: "IX_ReportCards_UserProfileId",
                schema: "sub",
                table: "ReportCard",
                newName: "IX_ReportCard_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_AssignmentGroupId",
                schema: "sub",
                table: "Assignment",
                newName: "IX_Assignment_AssignmentGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentGroups_UserProfileId",
                schema: "sub",
                table: "AssignmentGroup",
                newName: "IX_AssignmentGroup_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentGroups_SubjectCode",
                schema: "sub",
                table: "AssignmentGroup",
                newName: "IX_AssignmentGroup_SubjectCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "ReportCard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 125, DateTimeKind.Local).AddTicks(7302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 712, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "Assignment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 124, DateTimeKind.Local).AddTicks(5467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 711, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                schema: "sub",
                table: "AssignmentGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 4, 16, 7, 41, 124, DateTimeKind.Local).AddTicks(8920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 4, 16, 12, 3, 711, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                schema: "sub",
                table: "Subject",
                column: "SubjectCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCardSubject",
                schema: "sub",
                table: "ReportCardSubject",
                columns: new[] { "ReportCardId", "SubjectCode", "Year" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportCard",
                schema: "sub",
                table: "ReportCard",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignment",
                schema: "sub",
                table: "Assignment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignmentGroup",
                schema: "sub",
                table: "AssignmentGroup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_AssignmentGroup_AssignmentGroupId",
                schema: "sub",
                table: "Assignment",
                column: "AssignmentGroupId",
                principalSchema: "sub",
                principalTable: "AssignmentGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentGroup_Subject_SubjectCode",
                schema: "sub",
                table: "AssignmentGroup",
                column: "SubjectCode",
                principalSchema: "sub",
                principalTable: "Subject",
                principalColumn: "SubjectCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentGroup_UserProfiles_UserProfileId",
                schema: "sub",
                table: "AssignmentGroup",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCard_UserProfiles_UserProfileId",
                schema: "sub",
                table: "ReportCard",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCardSubject_ReportCard_ReportCardId",
                schema: "sub",
                table: "ReportCardSubject",
                column: "ReportCardId",
                principalSchema: "sub",
                principalTable: "ReportCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
