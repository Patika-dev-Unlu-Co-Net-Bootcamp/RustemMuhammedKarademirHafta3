using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnluCo.NetBootcamp.Odev3.Migrations
{
    public partial class init_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssistantId",
                table: "Educations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducatorId",
                table: "Educations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assistants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educators", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_AssistantId",
                table: "Educations",
                column: "AssistantId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EducatorId",
                table: "Educations",
                column: "EducatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Assistants_AssistantId",
                table: "Educations",
                column: "AssistantId",
                principalTable: "Assistants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Educators_EducatorId",
                table: "Educations",
                column: "EducatorId",
                principalTable: "Educators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Assistants_AssistantId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Educators_EducatorId",
                table: "Educations");

            migrationBuilder.DropTable(
                name: "Assistants");

            migrationBuilder.DropTable(
                name: "Educators");

            migrationBuilder.DropIndex(
                name: "IX_Educations_AssistantId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_EducatorId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AssistantId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "EducatorId",
                table: "Educations");
        }
    }
}
