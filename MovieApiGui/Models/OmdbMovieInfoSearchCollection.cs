using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MovieApiGui.Models;

public class OmdbMovieInfoSearchCollection
{
    [JsonPropertyName("Search")]
    public List<OmdbMovieInfo>? Search { get; set; }

    [JsonPropertyName("totalResults")]
    public string? TotalResults { get; set; }

    [JsonPropertyName("Response")]
    public string? Response { get; set; }
}