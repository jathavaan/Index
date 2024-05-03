using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Index.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedSubjectModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sub");

            migrationBuilder.CreateTable(
                name: "ReportCard",
                schema: "sub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 4, 12, 17, 7, 50, 290, DateTimeKind.Local).AddTicks(7625)),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportCard_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                schema: "sub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credit = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportCardSubject",
                schema: "sub",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ReportCardId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportCardSubject", x => new { x.ReportCardId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_ReportCardSubject_ReportCard_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "sub",
                        principalTable: "ReportCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportCardSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "sub",
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportCard_UserProfileId",
                schema: "sub",
                table: "ReportCard",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportCardSubject_SubjectId",
                schema: "sub",
                table: "ReportCardSubject",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportCardSubject",
                schema: "sub");

            migrationBuilder.DropTable(
                name: "ReportCard",
                schema: "sub");

            migrationBuilder.DropTable(
                name: "Subject",
                schema: "sub");
        }
    }
}
