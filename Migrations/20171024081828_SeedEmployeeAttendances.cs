using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace autoreg.Migrations
{
    public partial class SeedEmployeeAttendances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('94015', 'Suprayitno', 'AMI', '11 - General Manager', 'MIS Sub Division Head', '94015.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('07086', 'Herry Roby', 'AT1', '9 - Manager', 'MIS Department Head', '07086.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('97076', 'David Aripin Wihardja', 'AT4', '8 - Asst. Manager', 'Application Developer Sub Department Head', '97076.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('15142', 'Giovani Chinthya Chandra', 'AT2', '7 - Supervisor', 'Application Developer Sub Department Head', '15142.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('16190', 'Christian Wibisono', 'AT2', '7 - Supervisor', 'Application Developer Sub Department Head', '16190.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('16624', 'Hendry Setiawan', 'AGT', '7 - Supervisor', 'Application Developer Sub Department Head', '16624.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('11105', 'Christine Tenesa', 'AT1', '7 - Supervisor', 'System Development Sub Department Head', '11105.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('11259', 'Indra Surya Atmadja', 'AT3', '7 - Supervisor', 'System Development Sub Department Head', '11259.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('13474', 'Andreas Kristianto', 'AT2', '7 - Supervisor', 'System Development Sub Department Head', '13474.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('11004', 'Oddy Subyakto', 'AT1', '7 - Supervisor', 'Hardware & Network Sub Department Head', '11004.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('12607', 'Dicky Asharhadi', 'AMI', '5 - Staf', 'Hardware & Network Section Head', '12607.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('12115', 'Rian Rusman', 'AT5', '5 - Staf', 'Hardware & Network Section Head', '12115.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO EmployeeAttendances (Id, Name, CompanyOffice, Grade, PositionTitle, PhotoFilename, isAttend) VALUES ('16309', 'Joshua Yudistira Sjamsudin', 'AT1', '5 - Staf', 'Hardware & Network Section Head', '16309.jpg', 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM EmployeeAttendances");
        }
    }
}
