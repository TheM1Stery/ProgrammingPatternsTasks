using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MovieApiGui.Models;

public class TmdbMovieInfoSearchCollection
{
    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("results")]
    public List<TmdbMovieInfo>? Results { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}