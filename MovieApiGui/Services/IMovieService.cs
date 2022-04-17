using System.Collections.Generic;
using MovieApiGui.Models;

namespace MovieApiGui.Services;

public interface IMovieService
{
    public List<SearchInfo>? GetMovies(string searchString);

    public MovieInfo? GetMovieByTitle(string title);
}