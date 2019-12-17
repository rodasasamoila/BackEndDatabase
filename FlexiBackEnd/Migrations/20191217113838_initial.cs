using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlexiBackEnd.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    requestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accepted = table.Column<bool>(nullable: false),
                    deniedReason = table.Column<string>(nullable: true),
                    startHour = table.Column<int>(nullable: false),
                    endHour = table.Column<int>(nullable: false),
                    creationDate = table.Column<DateTime>(nullable: false),
                    exceptionDate = table.Column<DateTime>(nullable: false),
                    requestType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.requestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
