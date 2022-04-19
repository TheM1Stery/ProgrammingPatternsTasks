namespace TetrisForDummies.Figures;

public class TetrisFigureI : ITetrisFigure
{
    public int Position { get; set; }
    public Color? Color { get; set; }

    public string FigureRepresentation { get; } =
        "****";
}