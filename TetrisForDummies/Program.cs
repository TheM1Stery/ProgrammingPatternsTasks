using TetrisForDummies;
using TetrisForDummies.Factories;

var field = new Field(new TetrisFactory());

field.AddFigureToField(TetrisFigureType.Z);
field.AddFigureToField(TetrisFigureType.I);
field.AddFigureToField(TetrisFigureType.S);

Console.WriteLine(field.GetField());

