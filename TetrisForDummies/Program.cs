using TetrisForDummies;
using TetrisForDummies.Factories;
using TetrisForDummies.Figures;

var field = new Field(new TetrisFactory());

field.AddFigureToField(TetrisFigureType.Z, new Color(1,1,1));
field.AddFigureToField(TetrisFigureType.I, new Color(1,1,1));
field.AddFigureToField(TetrisFigureType.S, new Color(1,1,1));

Console.WriteLine(field.GetField());

