using AccSolWeb;
using SpotifyWeb;

namespace AccSol.React
{
    [GraphQLDescription("Client.")]
    public class GClient
    {
        [GraphQLDescription("The ID for the client.")]
        [ID]
        public string Id { get; set; }
        [GraphQLDescription("The code of the client.")]
        public string? Code { get; set; }
        [GraphQLDescription("The name of the client.")]
        public string? Name { get; set; }
        public GClient(int id, string code, string name)
        {
            Id = id.ToString();
            Code = code; 
            Name = name;
        }
        public GClient(Client obj)
        {
            Id = obj.Id.ToString();
            Code = obj.Code;
            Name = obj.Name;
            
        }
    }
}
