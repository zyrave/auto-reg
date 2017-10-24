using auto_reg.Controllers.Resources;
using auto_reg.Core.Models;
using AutoMapper;

namespace auto_reg.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resource
            CreateMap<EmployeeAttendance, EmployeeAttendanceResource>();
            CreateMap(typeof(QueryResult<>), typeof(QueryResultResource<>));

            // API Resource to Domain
            CreateMap<EmployeeAttendanceResource, EmployeeAttendance>();
            CreateMap<EmployeeAttendanceQueryResource, EmployeeAttendanceQuery>();
        }
    }
}
