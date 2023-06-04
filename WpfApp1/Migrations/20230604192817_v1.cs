using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp1.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdressBooks",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdressBooks", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "DataAdresses",
                columns: table => new
                {
                    Name2 = table.Column<string>(type: "TEXT", nullable: false),
                    SecondName = table.Column<string>(type: "TEXT", nullable: false),
                    Adress = table.Column<string>(type: "TEXT", nullable: false),
                    WorkPhone = table.Column<string>(type: "TEXT", nullable: false),
                    HomePhone = table.Column<string>(type: "TEXT", nullable: false),
                    PostInd = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataAdresses", x => x.Name2);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdressBooks");

            migrationBuilder.DropTable(
                name: "DataAdresses");
        }
    }
}
