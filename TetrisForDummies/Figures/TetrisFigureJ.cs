namespace TetrisForDummies.Figures;

public class TetrisFigureJ : ITetrisFigure
{
    public int Position { get; set; }
    public Color? Color { get; set; }
    public string FigureRepresentation { get; } = "*\n***";
}