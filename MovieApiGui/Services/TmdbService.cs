using System.Net;
using TMDbLib.Client;
using TMDbLib.Utilities.Serializer;

namespace MovieApiGui.Services;


// я для api TMDB использую NuGet package, чтобы его адаптировать под мой код, я создал этот клас
public class TmdbService : IMovieService
{
    private readonly TMDbClient _client;

    public TmdbService(TMDbClient client)
    {
        _client = client;
    }
}