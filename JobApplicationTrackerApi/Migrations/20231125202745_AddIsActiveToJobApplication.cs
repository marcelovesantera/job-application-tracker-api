using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplicationTrackerApi.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActiveToJobApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "JobApplications",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "JobApplications");
        }
    }
}
