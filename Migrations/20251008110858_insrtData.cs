using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class insrtData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Manager", "Name" },
                values: new object[,]
                {
                    { 1, "Ahmed", "IT" },
                    { 2, "Mohamed", "HR" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Degree", "DepartmentID", "MinDegree", "Name" },
                values: new object[,]
                {
                    { 1, 100, 1, 50, "C#" },
                    { 2, 200, 1, 80, "Java" },
                    { 3, 300, 2, 70, "Recruitment" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "ID", "DepartmentID", "Name", "address", "grade", "image" },
                values: new object[,]
                {
                    { 1, 1, "Sara", "Cairo", 100, "/images/1.jpg" },
                    { 2, 1, "Lina", "Giza", 80, "/images/2.jpg" },
                    { 3, 2, "Mona", "Alex", 90, "/images/3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "CRS_Results",
                columns: new[] { "ID", "Course_ID", "Degree", "TraineeID" },
                values: new object[,]
                {
                    { 1, 1, 90, 1 },
                    { 2, 2, 80, 2 },
                    { 3, 3, 70, 3 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "ID", "CourceID", "DepartmentID", "Image", "Name", "Salary", "address" },
                values: new object[,]
                {
                    { 1, 1, 1, "/images/1.jpg", "Ali", 5000, null },
                    { 2, 2, 1, "/images/2.jpg", "Omar", 6000, null },
                    { 3, 3, 2, "/images/3.jpg", "Hassan", 7000, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CRS_Results",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CRS_Results",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CRS_Results",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
