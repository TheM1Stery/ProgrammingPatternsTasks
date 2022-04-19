using TetrisForDummies.Figures;
namespace TetrisForDummies.Factories;

public class TetrisFactory : ITetrisFactory
{
    public ITetrisFigure GetFigure(TetrisFigureType figureType)
    {
        return figureType switch
        {
            TetrisFigureType.I => new TetrisFigureI(),
            TetrisFigureType.O => new TetrisFigureO(),
            TetrisFigureType.T => new TetrisFigureT(),
            TetrisFigureType.S => new TetrisFigureS(),
            TetrisFigureType.Z => new TetrisFigureZ(),
            TetrisFigureType.J => new TetrisFigureJ(),
            TetrisFigureType.L => new TetrisFigureL(),
            _ => throw new ArgumentException("Invalid tetris figure type")
        };
    }
}