namespace TetrisForDummies.Figures;

public record Color(byte FirstValue, byte SecondValue, byte ThirdValue);

public interface ITetrisFigure
{
    public int Position { get; set; }
    public Color? Color { get; set; }
    
    public string FigureRepresentation { get; }
}