using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using auto_reg.Core.Models;

namespace auto_reg.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<EmployeeAttendance> ApplyFiltering(this IQueryable<EmployeeAttendance> query, EmployeeAttendanceQuery queryObj)
        {
            if (!String.IsNullOrWhiteSpace(queryObj.Name))
                query = query.Where(c => c.Name.Contains(queryObj.Name));

            return query;
        }

        public static IQueryable<T> ApplyOrdering<T>(this IQueryable<T> query, IQueryObject queryObj, Dictionary<string, Expression<Func<T, object>>> columnsMap)
        {
            if (String.IsNullOrWhiteSpace(queryObj.SortBy) || !columnsMap.ContainsKey(queryObj.SortBy))
                return query;

            if (queryObj.IsSortAscending)
                return query = query.OrderBy(columnsMap[queryObj.SortBy]);
            else
                return query = query.OrderByDescending(columnsMap[queryObj.SortBy]);
        }

        public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> query, IQueryObject queryObj)
        {
            if (queryObj.Page <= 0)
                queryObj.Page = 1;

            if (queryObj.PageSize <= 0)
                queryObj.PageSize = 10;

            return query.Skip((queryObj.Page - 1) * queryObj.PageSize).Take(queryObj.PageSize);
        }
    }
}
