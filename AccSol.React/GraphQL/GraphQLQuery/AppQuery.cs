using AccSol.React.Entities.Contexts;
using AccSol.React.Entities.Models;

namespace AccSol.React.GraphQL.GraphQLQuery
{
    public class AppQuery 
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Employee> GetEmployees([Service] ApplicationContext context) =>
            context.Employees;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Department> GetDepartments([Service] ApplicationContext context) =>
            context.Departments;
    }
}
