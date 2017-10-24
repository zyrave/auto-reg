using System;

namespace auto_reg.Controllers.Resources
{
    public class EmployeeAttendanceResource
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CompanyOffice { get; set; }
        public string Grade { get; set; }
        public string PositionTitle { get; set; }
        public string PhotoFilename { get; set; }
        public bool? IsAttend { get; set; }
        public DateTime? AttendTime { get; set; }
    }
}
