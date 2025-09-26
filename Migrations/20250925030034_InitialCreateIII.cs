using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APPOINTMENT_SERVICE_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateIII : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeWorkSchedules_Employees_EmployeesId",
                table: "EmployeeWorkSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeWorkSchedules_WorkSchedules_WorkSchedulesId",
                table: "EmployeeWorkSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCompanies_Companies_CompaniesId",
                table: "UserCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCompanies_Users_UsersId",
                table: "UserCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RolesId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UsersId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCompanies",
                table: "UserCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeWorkSchedules",
                table: "EmployeeWorkSchedules");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "User_Roles");

            migrationBuilder.RenameTable(
                name: "UserCompanies",
                newName: "User_Companies");

            migrationBuilder.RenameTable(
                name: "EmployeeWorkSchedules",
                newName: "Employee_WorkSchedules");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UsersId",
                table: "User_Roles",
                newName: "IX_User_Roles_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCompanies_UsersId",
                table: "User_Companies",
                newName: "IX_User_Companies_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeWorkSchedules_WorkSchedulesId",
                table: "Employee_WorkSchedules",
                newName: "IX_Employee_WorkSchedules_WorkSchedulesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Roles",
                table: "User_Roles",
                columns: new[] { "RolesId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Companies",
                table: "User_Companies",
                columns: new[] { "CompaniesId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee_WorkSchedules",
                table: "Employee_WorkSchedules",
                columns: new[] { "EmployeesId", "WorkSchedulesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_WorkSchedules_Employees_EmployeesId",
                table: "Employee_WorkSchedules",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_WorkSchedules_WorkSchedules_WorkSchedulesId",
                table: "Employee_WorkSchedules",
                column: "WorkSchedulesId",
                principalTable: "WorkSchedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Companies_Companies_CompaniesId",
                table: "User_Companies",
                column: "CompaniesId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Companies_Users_UsersId",
                table: "User_Companies",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Roles_Roles_RolesId",
                table: "User_Roles",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Roles_Users_UsersId",
                table: "User_Roles",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_WorkSchedules_Employees_EmployeesId",
                table: "Employee_WorkSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_WorkSchedules_WorkSchedules_WorkSchedulesId",
                table: "Employee_WorkSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Companies_Companies_CompaniesId",
                table: "User_Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Companies_Users_UsersId",
                table: "User_Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Roles_Roles_RolesId",
                table: "User_Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Roles_Users_UsersId",
                table: "User_Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Roles",
                table: "User_Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Companies",
                table: "User_Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee_WorkSchedules",
                table: "Employee_WorkSchedules");

            migrationBuilder.RenameTable(
                name: "User_Roles",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "User_Companies",
                newName: "UserCompanies");

            migrationBuilder.RenameTable(
                name: "Employee_WorkSchedules",
                newName: "EmployeeWorkSchedules");

            migrationBuilder.RenameIndex(
                name: "IX_User_Roles_UsersId",
                table: "UserRoles",
                newName: "IX_UserRoles_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Companies_UsersId",
                table: "UserCompanies",
                newName: "IX_UserCompanies_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_WorkSchedules_WorkSchedulesId",
                table: "EmployeeWorkSchedules",
                newName: "IX_EmployeeWorkSchedules_WorkSchedulesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCompanies",
                table: "UserCompanies",
                columns: new[] { "CompaniesId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeWorkSchedules",
                table: "EmployeeWorkSchedules",
                columns: new[] { "EmployeesId", "WorkSchedulesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeWorkSchedules_Employees_EmployeesId",
                table: "EmployeeWorkSchedules",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeWorkSchedules_WorkSchedules_WorkSchedulesId",
                table: "EmployeeWorkSchedules",
                column: "WorkSchedulesId",
                principalTable: "WorkSchedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCompanies_Companies_CompaniesId",
                table: "UserCompanies",
                column: "CompaniesId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCompanies_Users_UsersId",
                table: "UserCompanies",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RolesId",
                table: "UserRoles",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UsersId",
                table: "UserRoles",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
