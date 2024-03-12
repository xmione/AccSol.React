using AccSol.React.GraphQL.GraphQLQuery;

namespace AccSol.React.GraphQL.GraphQLSchema
{
    public class AppSchema
    {
        public static ISchema Create(IServiceProvider provider)
        {
            return SchemaBuilder.New()
                .AddQueryType<AppQuery>()
                .Create();
        }
    }
}
