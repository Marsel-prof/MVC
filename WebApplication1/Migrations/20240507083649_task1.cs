using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class task1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Name", "Title" },
                values: new object[,]
                {
                    { 1, 21, "Marsel", "Software Engineer" },
                    { 2, 30, "Alice", "HR Manager" },
                    { 3, 25, "Bob", "Sales Executive" },
                    { 4, 28, "John", "Marketing Specialist" },
                    { 5, 27, "Emily", "Accountant" },
                    { 6, 29, "David", "Graphic Designer" },
                    { 7, 32, "Sophia", "Project Manager" },
                    { 8, 24, "Liam", "Customer Support" },
                    { 9, 31, "Olivia", "Operations Manager" },
                    { 10, 26, "Michael", "Software Developer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
