using AbstractFactoryTask.Units;

namespace AbstractFactoryTask.Factories;

public class ElectroUnitFactory : IUnitFactory
{
    public IArcher CreateArcher()
    {
        return new ElectroArcher();
    }

    public IInfantry CreateInfantry()
    {
        return new ElectroInfantry();
    }

    public ITrebuchet CreateTrebuchet()
    {
        return new ElectroTrebuchet();
    }

    public ICavalry CreateCavalry()
    {
        return new ElectroCavalry();
    }
}