using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examm.Migrations
{
    public partial class relationnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Locations_Country_Id",
                table: "Locations",
                column: "Country_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Department_Id",
                table: "Employees",
                column: "Department_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Dependents_Eployee_Id",
                table: "Dependents",
                column: "Eployee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Location_Id",
                table: "Departments",
                column: "Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Region_Id",
                table: "Countries",
                column: "Region_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Regions_Region_Id",
                table: "Countries",
                column: "Region_Id",
                principalTable: "Regions",
                principalColumn: "Region_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Locations_Location_Id",
                table: "Departments",
                column: "Location_Id",
                principalTable: "Locations",
                principalColumn: "Location_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dependents_Employees_Eployee_Id",
                table: "Dependents",
                column: "Eployee_Id",
                principalTable: "Employees",
                principalColumn: "Employee_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_Department_Id",
                table: "Employees",
                column: "Department_Id",
                principalTable: "Departments",
                principalColumn: "Department_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Countries_Country_Id",
                table: "Locations",
                column: "Country_Id",
                principalTable: "Countries",
                principalColumn: "Country_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Regions_Region_Id",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Locations_Location_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Dependents_Employees_Eployee_Id",
                table: "Dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_Department_Id",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Countries_Country_Id",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_Country_Id",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Department_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Dependents_Eployee_Id",
                table: "Dependents");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Location_Id",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Countries_Region_Id",
                table: "Countries");
        }
    }
}
