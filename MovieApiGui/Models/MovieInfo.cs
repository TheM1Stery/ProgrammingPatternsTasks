using System.Drawing;
using System.IO;
using System.Net;

namespace MovieApiGui.Models;

public class MovieInfo
{
    public string? Title { get; init; }
    
    public string? Plot { get; init; }
    
    public string? Year { get; init; }
    
    public string? PosterPath { get; init; }
    
    public override string ToString()
    {
        return $"Title: {Title}\n" + $"Year: {Year}\n";
    }
}