using Microsoft.EntityFrameworkCore.Migrations;

namespace Pagination.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Demo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Demo",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chan Sin Yow" },
                    { 21, "Steve" },
                    { 22, "Steve" },
                    { 23, "Steve" },
                    { 24, "Steve" },
                    { 25, "Steve" },
                    { 26, "Sos" },
                    { 20, "Steve" },
                    { 27, "Sos" },
                    { 29, "Sos" },
                    { 30, "Sos" },
                    { 31, "Covid" },
                    { 32, "Covid" },
                    { 33, "Covid" },
                    { 34, "Covid" },
                    { 28, "Sos" },
                    { 19, "Peter Parker" },
                    { 18, "Tony Stark" },
                    { 17, "Sam" },
                    { 2, "Yong Han" },
                    { 3, "Amelia" },
                    { 4, "Amy" },
                    { 5, "Angela" },
                    { 6, "Anna" },
                    { 7, "Anne" },
                    { 8, "Bella" },
                    { 9, "Belle" },
                    { 10, "Carol" },
                    { 11, "Chloe" },
                    { 12, "Claire" },
                    { 13, "Diana" },
                    { 14, "Ella" },
                    { 15, "Emily" },
                    { 16, "Emma" },
                    { 35, "Covid" },
                    { 36, "Covid" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demo");
        }
    }
}
