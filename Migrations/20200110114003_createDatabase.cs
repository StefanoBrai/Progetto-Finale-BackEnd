using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgettoFinaleBack.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    ProtId = table.Column<string>(nullable: false),
                    StartDate = table.Column<string>(nullable: true),
                    ReceiveDate = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Sender = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Object = table.Column<string>(nullable: true),
                    Attachment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.ProtId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mails");
        }
    }
}
