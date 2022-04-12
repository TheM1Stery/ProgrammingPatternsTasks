using AbstractFactoryTask.Units;

namespace AbstractFactoryTask.Factories;

public class DendroUnitFactory : IUnitFactory
{
    public IArcher CreateArcher()
    {
        return new DendroArcher();
    }

    public IInfantry CreateInfantry()
    {
        return new DendroInfantry();
    }

    public ITrebuchet CreateTrebuchet()
    {
        return new DendroTrebuchet();
    }

    public ICavalry CreateCavalry()
    {
        return new DendroCavalry();
    }
}