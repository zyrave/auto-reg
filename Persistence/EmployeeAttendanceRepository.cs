using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using auto_reg.Core;
using auto_reg.Core.Models;
using auto_reg.Extensions;
using Microsoft.EntityFrameworkCore;

namespace auto_reg.Persistence
{
    public class EmployeeAttendanceRepository : IEmployeeAttendanceRepository
    {
        private readonly ApplicationDbContext context;

        public EmployeeAttendanceRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.context.Database.AutoTransactionsEnabled = false;
        }

        public async Task<QueryResult<EmployeeAttendance>> GetEmployeeAttendances(EmployeeAttendanceQuery queryObj)
        {
            var result = new QueryResult<EmployeeAttendance>();
            var query = context.EmployeeAttendances.AsQueryable();

            query = query.ApplyFiltering(queryObj);

            var columnsMap = new Dictionary<string, Expression<Func<EmployeeAttendance, object>>>()
            {
                ["id"] = e => e.Id,
                ["name"] = e => e.Name,
                ["companyOffice"] = e => e.CompanyOffice,
                ["grade"] = e => e.Grade,
                ["positionTitle"] = e => e.PositionTitle,
                ["photoFilename"] = e => e.PhotoFilename,
                ["isAttend"] = e => e.IsAttend,
                ["attendTime"] = e => e.AttendTime
            };
            query = query.ApplyOrdering(queryObj, columnsMap);

            result.TotalItems = await query.CountAsync();

            query = query.ApplyPaging(queryObj);

            result.Items = await query.ToListAsync();

            return result;
        }

        public async Task<EmployeeAttendance> GetEmployeeAttendance(string id)
        {
            return await context.EmployeeAttendances.SingleOrDefaultAsync(e => e.Id == id);
        }

        public void Add(EmployeeAttendance employeeAttendance)
        {
            context.EmployeeAttendances.Add(employeeAttendance);
        }

        public void Remove(EmployeeAttendance employeeAttendance)
        {
            context.Remove(employeeAttendance);
        }
    }
}
