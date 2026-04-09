using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlertsProject.Migrations.AliesAlertsDB
{
    public partial class AddUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlertsTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    رمزالخطأ = table.Column<double>(name: "رمز الخطأ", type: "float", nullable: true),
                    اسمالخطأ = table.Column<string>(name: "اسم الخطأ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    نوعالخطأ = table.Column<string>(name: "نوع الخطأ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    شرحمختصر = table.Column<string>(name: "شرح مختصر", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertsTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ErrorAlerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    errorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    errorType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorAlerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usersinfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usersinfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlertsTable");

            migrationBuilder.DropTable(
                name: "ErrorAlerts");

            migrationBuilder.DropTable(
                name: "Usersinfo");
        }
    }
}
