namespace auto_reg.Controllers.Resources
{
    public class EmployeeAttendanceQueryResource
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}
