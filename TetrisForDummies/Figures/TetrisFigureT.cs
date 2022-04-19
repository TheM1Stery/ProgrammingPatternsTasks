namespace TetrisForDummies.Figures;

public class TetrisFigureT : ITetrisFigure
{
    public int Position { get; set; }
    public Color? Color { get; set; }
    public string FigureRepresentation { get; } = " * \n***";
}