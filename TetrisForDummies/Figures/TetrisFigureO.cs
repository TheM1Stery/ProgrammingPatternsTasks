﻿namespace TetrisForDummies.Figures;

public class TetrisFigureO : ITetrisFigure
{
    public int Position { get; set; }
    public Color? Color { get; set; }
    public string FigureRepresentation { get; } = "**\n**";
}