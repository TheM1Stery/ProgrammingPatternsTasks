using System.Collections.Generic;
using MovieApiGui.Models;

namespace MovieApiGui.Services;

public interface IMovieService
{
    public List<MovieInfo>? GetMovies(string searchString);
}