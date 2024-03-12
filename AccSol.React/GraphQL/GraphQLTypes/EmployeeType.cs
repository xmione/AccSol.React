using AccSol.React.Entities.Models;

namespace AccSol.React.GraphQL.GraphQLTypes
{
    public class EmployeeType : ObjectType<Employee>
    {
        protected override void Configure(IObjectTypeDescriptor<Employee> descriptor)
        {
            descriptor
                .Field(x => x.ID)
                .Description("ID property from the employee object.")
                .Type<NonNullType<IdType>>();

            descriptor
                .Field(x => x.FirstName)
                .Description("FirstName property from the employee object.");

            descriptor
                .Field(x => x.MiddleName)
                .Description("MiddleName property from the employee object.");

            descriptor
                .Field(x => x.LastName)
                .Description("LastName property from the employee object.");

            descriptor
                .Field(x => x.DepartmentID)
                .Description("DepartmentID property from the employee object.");

            descriptor
                .Field(x => x.Department)
                .Description("Department property from the employee object.")
                .Type<DepartmentType>();
        }
    }
}
