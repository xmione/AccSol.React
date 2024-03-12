using AccSolWeb;
using SpotifyWeb;

namespace AccSol.React;

public class Query
{
    [GraphQLDescription("Playlists hand-picked to be featured to all users.")]
    public async Task<List<Playlist>> FeaturedPlaylists(SpotifyService spotifyService)
    {
        var response = await spotifyService.GetFeaturedPlaylistsAsync();
        // var items = response.Playlists.Items;
        // var playlists = items.Select(item => new Playlist(item));
        // return playlists.ToList();
        return response.Playlists.Items.Select(item => new Playlist(item)).ToList();
    }


    [GraphQLDescription("Company clients.")]
    public async Task<List<GClient>> CompanyClients([Service]AccSolService accSolService)
    {
        var response = await accSolService.GetAllAsync();

        var list = response.Select(item => new GClient(item)).ToList();

        return list;
    }

}
