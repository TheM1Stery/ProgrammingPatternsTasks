using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MovieApiGui.Models.Omdb;

public class OmdbMovieInfoSearchCollection
{
    [JsonPropertyName("Search")]
    public List<OmdbSearchMovieInfo>? Search { get; set; }

    [JsonPropertyName("totalResults")]
    public string? TotalResults { get; set; }

    [JsonPropertyName("Response")]
    public string? Response { get; set; }
}