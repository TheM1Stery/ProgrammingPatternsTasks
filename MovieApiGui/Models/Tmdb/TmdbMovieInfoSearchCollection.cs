using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MovieApiGui.Models.Tmdb;

public class TmdbMovieInfoSearchCollection
{
    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("results")]
    public List<TmdbMovieSearchInfo>? Results { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}