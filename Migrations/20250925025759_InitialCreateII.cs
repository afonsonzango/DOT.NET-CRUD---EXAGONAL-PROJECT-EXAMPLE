using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APPOINTMENT_SERVICE_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateII : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_work_schedules_Employees_EmployeesId",
                table: "employee_work_schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_employee_work_schedules_WorkSchedules_WorkSchedulesId",
                table: "employee_work_schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_user_companies_Companies_CompaniesId",
                table: "user_companies");

            migrationBuilder.DropForeignKey(
                name: "FK_user_companies_Users_UsersId",
                table: "user_companies");

            migrationBuilder.DropForeignKey(
                name: "FK_user_roles_Roles_RolesId",
                table: "user_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_user_roles_Users_UsersId",
                table: "user_roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_roles",
                table: "user_roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_companies",
                table: "user_companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employee_work_schedules",
                table: "employee_work_schedules");

            migrationBuilder.RenameTable(
                name: "user_roles",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "user_companies",
                newName: "UserCompanies");

            migrationBuilder.RenameTable(
                name: "employee_work_schedules",
                newName: "EmployeeWorkSchedules");

            migrationBuilder.RenameIndex(
                name: "IX_user_roles_UsersId",
                table: "UserRoles",
                newName: "IX_UserRoles_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_user_companies_UsersId",
                table: "UserCompanies",
                newName: "IX_UserCompanies_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_employee_work_schedules_WorkSchedulesId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "user_roles");

            migrationBuilder.RenameTable(
                name: "UserCompanies",
                newName: "user_companies");

            migrationBuilder.RenameTable(
                name: "EmployeeWorkSchedules",
                newName: "employee_work_schedules");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UsersId",
                table: "user_roles",
                newName: "IX_user_roles_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCompanies_UsersId",
                table: "user_companies",
                newName: "IX_user_companies_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeWorkSchedules_WorkSchedulesId",
                table: "employee_work_schedules",
                newName: "IX_employee_work_schedules_WorkSchedulesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_roles",
                table: "user_roles",
                columns: new[] { "RolesId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_companies",
                table: "user_companies",
                columns: new[] { "CompaniesId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_employee_work_schedules",
                table: "employee_work_schedules",
                columns: new[] { "EmployeesId", "WorkSchedulesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_employee_work_schedules_Employees_EmployeesId",
                table: "employee_work_schedules",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employee_work_schedules_WorkSchedules_WorkSchedulesId",
                table: "employee_work_schedules",
                column: "WorkSchedulesId",
                principalTable: "WorkSchedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_companies_Companies_CompaniesId",
                table: "user_companies",
                column: "CompaniesId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_companies_Users_UsersId",
                table: "user_companies",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_roles_Roles_RolesId",
                table: "user_roles",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_roles_Users_UsersId",
                table: "user_roles",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
