using AccSol.React.Entities.Models;

namespace AccSol.React.GraphQL.GraphQLTypes
{
    public class DepartmentType : ObjectType<Department>
    {
        protected override void Configure(IObjectTypeDescriptor<Department> descriptor)
        {
            descriptor
                .Field(x => x.ID)
                .Description("ID property from the department object.")
                .Type<NonNullType<IdType>>();

            descriptor
                .Field(x => x.Code)
                .Description("Code property from the department object.");

            descriptor
                .Field(x => x.Name)
                .Description("Name property from the department object.");
        }
    }

}
