using Microsoft.EntityFrameworkCore.Migrations;

namespace Semita3.Data.Migrations
{
    public partial class updateTicketModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Project_ProjectId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ProjectId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ProjectTitle",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Project",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_TicketId",
                table: "Project",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Ticket_TicketId",
                table: "Project",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Ticket_TicketId",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_TicketId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Project");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProjectTitle",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ProjectId",
                table: "Ticket",
                column: "ProjectId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Project_ProjectId",
                table: "Ticket",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
