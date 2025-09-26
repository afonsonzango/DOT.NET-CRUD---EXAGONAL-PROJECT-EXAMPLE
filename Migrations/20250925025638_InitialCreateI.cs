using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APPOINTMENT_SERVICE_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyEntityUserEntity_Companies_CompaniesId",
                table: "CompanyEntityUserEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyEntityUserEntity_Users_UsersId",
                table: "CompanyEntityUserEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEntityWorkScheduleEntity_Employees_EmployeesId",
                table: "EmployeeEntityWorkScheduleEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEntityWorkScheduleEntity_WorkSchedules_WorkSchedule~",
                table: "EmployeeEntityWorkScheduleEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleEntityUserEntity_Roles_RolesId",
                table: "RoleEntityUserEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleEntityUserEntity_Users_UsersId",
                table: "RoleEntityUserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleEntityUserEntity",
                table: "RoleEntityUserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeEntityWorkScheduleEntity",
                table: "EmployeeEntityWorkScheduleEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyEntityUserEntity",
                table: "CompanyEntityUserEntity");

            migrationBuilder.RenameTable(
                name: "RoleEntityUserEntity",
                newName: "user_roles");

            migrationBuilder.RenameTable(
                name: "EmployeeEntityWorkScheduleEntity",
                newName: "employee_work_schedules");

            migrationBuilder.RenameTable(
                name: "CompanyEntityUserEntity",
                newName: "user_companies");

            migrationBuilder.RenameIndex(
                name: "IX_RoleEntityUserEntity_UsersId",
                table: "user_roles",
                newName: "IX_user_roles_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeEntityWorkScheduleEntity_WorkSchedulesId",
                table: "employee_work_schedules",
                newName: "IX_employee_work_schedules_WorkSchedulesId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyEntityUserEntity_UsersId",
                table: "user_companies",
                newName: "IX_user_companies_UsersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_roles",
                table: "user_roles",
                columns: new[] { "RolesId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_employee_work_schedules",
                table: "employee_work_schedules",
                columns: new[] { "EmployeesId", "WorkSchedulesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_companies",
                table: "user_companies",
                columns: new[] { "CompaniesId", "UsersId" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "RoleEntityUserEntity");

            migrationBuilder.RenameTable(
                name: "user_companies",
                newName: "CompanyEntityUserEntity");

            migrationBuilder.RenameTable(
                name: "employee_work_schedules",
                newName: "EmployeeEntityWorkScheduleEntity");

            migrationBuilder.RenameIndex(
                name: "IX_user_roles_UsersId",
                table: "RoleEntityUserEntity",
                newName: "IX_RoleEntityUserEntity_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_user_companies_UsersId",
                table: "CompanyEntityUserEntity",
                newName: "IX_CompanyEntityUserEntity_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_employee_work_schedules_WorkSchedulesId",
                table: "EmployeeEntityWorkScheduleEntity",
                newName: "IX_EmployeeEntityWorkScheduleEntity_WorkSchedulesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleEntityUserEntity",
                table: "RoleEntityUserEntity",
                columns: new[] { "RolesId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyEntityUserEntity",
                table: "CompanyEntityUserEntity",
                columns: new[] { "CompaniesId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeEntityWorkScheduleEntity",
                table: "EmployeeEntityWorkScheduleEntity",
                columns: new[] { "EmployeesId", "WorkSchedulesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyEntityUserEntity_Companies_CompaniesId",
                table: "CompanyEntityUserEntity",
                column: "CompaniesId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyEntityUserEntity_Users_UsersId",
                table: "CompanyEntityUserEntity",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEntityWorkScheduleEntity_Employees_EmployeesId",
                table: "EmployeeEntityWorkScheduleEntity",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEntityWorkScheduleEntity_WorkSchedules_WorkSchedule~",
                table: "EmployeeEntityWorkScheduleEntity",
                column: "WorkSchedulesId",
                principalTable: "WorkSchedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleEntityUserEntity_Roles_RolesId",
                table: "RoleEntityUserEntity",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleEntityUserEntity_Users_UsersId",
                table: "RoleEntityUserEntity",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
