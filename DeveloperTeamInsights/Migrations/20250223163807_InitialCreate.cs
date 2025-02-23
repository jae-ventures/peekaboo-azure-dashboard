using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeveloperTeamInsights.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeveloperName = table.Column<string>(type: "TEXT", nullable: true),
                    NumberTasksWorked = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberActivePRs = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberReviewsConducted = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberDocumentsGenerated = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberDocumentsReviewed = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Developers");
        }
    }
}
