using AbstractFactoryTask.Units;

namespace AbstractFactoryTask.Factories;

public class CryoUnitFactory : IUnitFactory
{
    public IArcher CreateArcher()
    {
        return new CryoArcher();
    }

    public IInfantry CreateInfantry()
    {
        return new CryoInfantry();
    }

    public ITrebuchet CreateTrebuchet()
    {
        return new CryoTrebuchet();
    }

    public ICavalry CreateCavalry()
    {
        return new CryoCavalry();
    }
}