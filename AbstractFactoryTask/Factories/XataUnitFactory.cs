using AbstractFactoryTask.Units;

namespace AbstractFactoryTask.Factories;

public class XataUnitFactory : IUnitFactory
{
    public IArcher CreateArcher()
    {
        return new IgniArcher();
    }

    public IInfantry CreateInfantry()
    {
        return new XataInfantry();
    }

    public ITrebuchet CreateTrebuchet()
    {
        return new XataTrebuchet();
    }

    public ICavalry CreateCavalry()
    {
        return new XataCavalry();
    }
}