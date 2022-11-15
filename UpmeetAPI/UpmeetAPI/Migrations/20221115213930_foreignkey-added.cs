using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpmeetAPI.Migrations
{
    public partial class foreignkeyadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FavoritedEvents_EventId",
                table: "FavoritedEvents",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoritedEvents_Events_EventId",
                table: "FavoritedEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoritedEvents_Events_EventId",
                table: "FavoritedEvents");

            migrationBuilder.DropIndex(
                name: "IX_FavoritedEvents_EventId",
                table: "FavoritedEvents");
        }
    }
}
