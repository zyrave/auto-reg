using auto_reg.Extensions;

namespace auto_reg.Core.Models
{
    public class EmployeeAttendanceQuery : IQueryObject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}
