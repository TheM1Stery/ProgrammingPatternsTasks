using System.Text.Json.Serialization;

namespace MovieApiGui.Models.Omdb;

public class OmdbSearchMovieInfo
{
    [JsonPropertyName("Title")]
    public string? Title { get; set; }

    [JsonPropertyName("Year")]
    public string? Year { get; set; }

    [JsonPropertyName("imdbID")]
    public string? ImdbId { get; set; }

    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    [JsonPropertyName("Poster")]
    public string? Poster { get; set; }
}