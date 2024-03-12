using SpotifyWeb;

namespace AccSol.React
{
    [GraphQLDescription("A curated collection of tracks designed for a specific activity or mood.")]
    public class Playlist
    {
        [GraphQLDescription("The ID for the playlist.")]
        [ID]
        public string Id { get; }

        [GraphQLDescription("The name of the playlist.")]
        public string Name { get; set; }

        [GraphQLDescription("Describes the playlist, what to expect and entices the user to listen.")]
        public string? Description { get; set; }

        public Playlist(string id, string name)
        {
            Id = id;
            Name = name;
        }
        public Playlist(PlaylistSimplified obj)
        {
            Id = obj.Id;
            Name = obj.Name;
            Description = obj.Description;
        }
    }
}
