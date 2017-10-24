using System;
using System.ComponentModel.DataAnnotations;

namespace auto_reg.Core.Models
{
    public class EmployeeAttendance
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyOffice { get; set; }
        [Required]
        [StringLength(100)]
        public string Grade { get; set; }
        [Required]
        [StringLength(100)]
        public string PositionTitle { get; set; }
        [StringLength(100)]
        public string PhotoFilename { get; set; }
        public bool? IsAttend { get; set; }
        public DateTime? AttendTime { get; set; }
    }
}
