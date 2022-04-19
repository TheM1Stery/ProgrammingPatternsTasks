using TetrisForDummies.Figures;

namespace TetrisForDummies.Factories;

public interface ITetrisFactory
{
    public ITetrisFigure GetFigure(TetrisFigureType figureType);
}