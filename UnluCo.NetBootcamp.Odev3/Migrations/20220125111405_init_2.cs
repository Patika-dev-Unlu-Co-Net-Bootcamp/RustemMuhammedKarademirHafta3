using Microsoft.EntityFrameworkCore.Migrations;

namespace UnluCo.NetBootcamp.Odev3.Migrations
{
    public partial class init_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Assistants_AssistantId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Educators_EducatorId",
                table: "Educations");

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

            migrationBuilder.CreateTable(
                name: "AssistantEducation",
                columns: table => new
                {
                    AssistantsId = table.Column<int>(type: "int", nullable: false),
                    EducationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssistantEducation", x => new { x.AssistantsId, x.EducationsId });
                    table.ForeignKey(
                        name: "FK_AssistantEducation_Assistants_AssistantsId",
                        column: x => x.AssistantsId,
                        principalTable: "Assistants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssistantEducation_Educations_EducationsId",
                        column: x => x.EducationsId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationEducator",
                columns: table => new
                {
                    EducationsId = table.Column<int>(type: "int", nullable: false),
                    EducatorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationEducator", x => new { x.EducationsId, x.EducatorsId });
                    table.ForeignKey(
                        name: "FK_EducationEducator_Educations_EducationsId",
                        column: x => x.EducationsId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationEducator_Educators_EducatorsId",
                        column: x => x.EducatorsId,
                        principalTable: "Educators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssistantEducation_EducationsId",
                table: "AssistantEducation",
                column: "EducationsId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationEducator_EducatorsId",
                table: "EducationEducator",
                column: "EducatorsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssistantEducation");

            migrationBuilder.DropTable(
                name: "EducationEducator");

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
    }
}
