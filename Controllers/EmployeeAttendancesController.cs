using System.Threading.Tasks;
using auto_reg.Controllers.Resources;
using auto_reg.Core;
using auto_reg.Core.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace auto_reg.Controllers
{
    [Route("/api/[controller]")]
    public class EmployeeAttendancesController : Controller
    {
        private readonly IEmployeeAttendanceRepository employeeAttendanceRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public EmployeeAttendancesController(IEmployeeAttendanceRepository employeeAttendanceRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.employeeAttendanceRepository = employeeAttendanceRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        // GET: api/employeeattendances
        [HttpGet]
        public async Task<QueryResultResource<EmployeeAttendanceResource>> GetEmployeeAttendances(EmployeeAttendanceQueryResource filterResource)
        {
            var filter = mapper.Map<EmployeeAttendanceQueryResource, EmployeeAttendanceQuery>(filterResource);
            var queryResult = await employeeAttendanceRepository.GetEmployeeAttendances(filter);

            return mapper.Map<QueryResult<EmployeeAttendance>, QueryResultResource<EmployeeAttendanceResource>>(queryResult);
        }

        // GET: api/employeeattendances/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeAttendance(string id)
        {
            var employeeAttendance = await employeeAttendanceRepository.GetEmployeeAttendance(id);

            if (employeeAttendance == null)
                return NotFound();

            var employeAttendanceResource = mapper.Map<EmployeeAttendance, EmployeeAttendanceResource>(employeeAttendance);

            return Ok(employeAttendanceResource);
        }

        // POST: api/employeeattendances
        [HttpPost]
        public async Task<IActionResult> CreateEmployeeAttendance([FromBody] EmployeeAttendanceResource employeeAttendanceResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeAttendance = mapper.Map<EmployeeAttendanceResource, EmployeeAttendance>(employeeAttendanceResource);

            employeeAttendanceRepository.Add(employeeAttendance);
            await unitOfWork.CompleteAsync();

            employeeAttendance = await employeeAttendanceRepository.GetEmployeeAttendance(employeeAttendance.Id);
            var result = mapper.Map<EmployeeAttendance, EmployeeAttendanceResource>(employeeAttendance);

            return Ok(result);
        }

        // PUT: api/employeeattendances/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployeeAttendance(string id, [FromBody] EmployeeAttendanceResource employeeAttendanceResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeAttendance = await employeeAttendanceRepository.GetEmployeeAttendance(id);

            if (employeeAttendance == null)
                return NotFound();

            mapper.Map<EmployeeAttendanceResource, EmployeeAttendance>(employeeAttendanceResource, employeeAttendance);

            await unitOfWork.CompleteAsync();

            employeeAttendance = await employeeAttendanceRepository.GetEmployeeAttendance(employeeAttendance.Id);
            var result = mapper.Map<EmployeeAttendance, EmployeeAttendanceResource>(employeeAttendance);

            return Ok(result);
        }

        // DELETE: api/employeeattendances/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeAttendance(string id)
        {
            var employeeAttendance = await employeeAttendanceRepository.GetEmployeeAttendance(id);

            if (employeeAttendance == null)
                return NotFound();

            employeeAttendanceRepository.Remove(employeeAttendance);
            await unitOfWork.CompleteAsync();

            return Ok(id);
        }
    }
}
