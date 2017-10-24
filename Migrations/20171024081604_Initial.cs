using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace autoreg.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeAttendances",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CompanyOffice = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Grade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PositionTitle = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PhotoFilename = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsAttend = table.Column<bool>(type: "bit", nullable: true),
                    AttendTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAttendances", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeAttendances");
        }
    }
}
