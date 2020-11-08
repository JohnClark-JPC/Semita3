using Microsoft.EntityFrameworkCore.Migrations;

namespace Semita3.Data.Migrations
{
    public partial class tickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ticket_ProjectId",
                table: "Ticket");

            migrationBuilder.AddColumn<string>(
                name: "ProjectTitle",
                table: "Ticket",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ProjectId",
                table: "Ticket",
                column: "ProjectId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ticket_ProjectId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ProjectTitle",
                table: "Ticket");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ProjectId",
                table: "Ticket",
                column: "ProjectId");
        }
    }
}
