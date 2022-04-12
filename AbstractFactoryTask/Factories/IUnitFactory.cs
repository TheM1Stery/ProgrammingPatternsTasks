using AbstractFactoryTask.Units;

namespace AbstractFactoryTask.Factories;

public interface IUnitFactory
{
    public IArcher CreateArcher();

    public IInfantry CreateInfantry();

    public ITrebuchet CreateTrebuchet();

    public ICavalry CreateCavalry();
}