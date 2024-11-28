using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment3_NilavarasuKumar.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_CVModel_CVModelId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_CVModel_CVModelId",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_CVModel_CVModelId",
                table: "Skill");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperience_CVModel_CVModelId",
                table: "WorkExperience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkExperience",
                table: "WorkExperience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skill",
                table: "Skill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                table: "Language");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Education",
                table: "Education");

            migrationBuilder.RenameTable(
                name: "WorkExperience",
                newName: "WorkExperiences");

            migrationBuilder.RenameTable(
                name: "Skill",
                newName: "Skills");

            migrationBuilder.RenameTable(
                name: "Language",
                newName: "Languages");

            migrationBuilder.RenameTable(
                name: "Education",
                newName: "Educations");

            migrationBuilder.RenameIndex(
                name: "IX_WorkExperience_CVModelId",
                table: "WorkExperiences",
                newName: "IX_WorkExperiences_CVModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Skill_CVModelId",
                table: "Skills",
                newName: "IX_Skills_CVModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Language_CVModelId",
                table: "Languages",
                newName: "IX_Languages_CVModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Education_CVModelId",
                table: "Educations",
                newName: "IX_Educations_CVModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkExperiences",
                table: "WorkExperiences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Educations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_CVModel_CVModelId",
                table: "Educations",
                column: "CVModelId",
                principalTable: "CVModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_CVModel_CVModelId",
                table: "Languages",
                column: "CVModelId",
                principalTable: "CVModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_CVModel_CVModelId",
                table: "Skills",
                column: "CVModelId",
                principalTable: "CVModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_CVModel_CVModelId",
                table: "WorkExperiences",
                column: "CVModelId",
                principalTable: "CVModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_CVModel_CVModelId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_CVModel_CVModelId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_CVModel_CVModelId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_CVModel_CVModelId",
                table: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkExperiences",
                table: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.RenameTable(
                name: "WorkExperiences",
                newName: "WorkExperience");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "Skill");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "Language");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "Education");

            migrationBuilder.RenameIndex(
                name: "IX_WorkExperiences_CVModelId",
                table: "WorkExperience",
                newName: "IX_WorkExperience_CVModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_CVModelId",
                table: "Skill",
                newName: "IX_Skill_CVModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_CVModelId",
                table: "Language",
                newName: "IX_Language_CVModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Educations_CVModelId",
                table: "Education",
                newName: "IX_Education_CVModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkExperience",
                table: "WorkExperience",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skill",
                table: "Skill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                table: "Language",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Education",
                table: "Education",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_CVModel_CVModelId",
                table: "Education",
                column: "CVModelId",
                principalTable: "CVModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_CVModel_CVModelId",
                table: "Language",
                column: "CVModelId",
                principalTable: "CVModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_CVModel_CVModelId",
                table: "Skill",
                column: "CVModelId",
                principalTable: "CVModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperience_CVModel_CVModelId",
                table: "WorkExperience",
                column: "CVModelId",
                principalTable: "CVModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
