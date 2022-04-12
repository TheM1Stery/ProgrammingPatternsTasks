using AbstractFactoryTask.Units;

namespace AbstractFactoryTask.Factories;

public class IgniUnitFactory : IUnitFactory
{
    public IArcher CreateArcher()
    {
        return new IgniArcher();
    }

    public IInfantry CreateInfantry()
    {
        return new IgniInfantry();
    }

    public ITrebuchet CreateTrebuchet()
    {
        return new IgniTrebuchet();
    }

    public ICavalry CreateCavalry()
    {
        return new IgniCavalry();
    }
}