namespace TetrisForDummies.Figures;

public class TetrisFigureS : ITetrisFigure
{
    public int Position { get; set; }
    public Color? Color { get; set; }
    public string FigureRepresentation { get; } = " **\n**";
}