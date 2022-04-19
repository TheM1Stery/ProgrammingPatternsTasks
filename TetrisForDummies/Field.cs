using System.Text;
using TetrisForDummies.Factories;
using TetrisForDummies.Figures;

namespace TetrisForDummies;

public class Field
{
    private List<ITetrisFigure?> _figures;

    private readonly ITetrisFactory? _factory;

    public Field(ITetrisFactory factory)
    {
        _figures = new List<ITetrisFigure?>();
        _factory = factory;
    }

    public void AddFigureToField(TetrisFigureType figureType, Color color)
    {
        var figure = _factory?.GetFigure(figureType);
        if (figure == null) 
            return;
        figure.Color = color;
        figure.Position = _figures.Count + 1;
        _figures.Add(figure);
    }

    public string GetField()
    {
        var builder = new StringBuilder();
        foreach (var tetrisFigure in _figures)
        {
            builder.Append(tetrisFigure?.FigureRepresentation + "\n\n");
        }
        return builder.ToString();
    }
    
}