﻿using System.Text.Json.Serialization;

namespace MovieApiGui.Models.Tmdb;

public class SpokenLanguage
{
    [JsonPropertyName("english_name")]
    public string? EnglishName { get; set; }

    [JsonPropertyName("iso_639_1")]
    public string? Iso6391 { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}