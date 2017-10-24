using System.Threading.Tasks;
using auto_reg.Core.Models;

namespace auto_reg.Core
{
    public interface IEmployeeAttendanceRepository
    {
        Task<QueryResult<EmployeeAttendance>> GetEmployeeAttendances(EmployeeAttendanceQuery queryObj);
        Task<EmployeeAttendance> GetEmployeeAttendance(string id);
        void Add(EmployeeAttendance employeeAttendance);
        void Remove(EmployeeAttendance employeeAttendance);
    }
}
