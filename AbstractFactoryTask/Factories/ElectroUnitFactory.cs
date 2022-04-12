using AbstractFactoryTask.Units;

namespace AbstractFactoryTask.Factories;

public class ElectroUnitFactory : IUnitFactory
{
    public IArcher CreateArcher()
    {
        throw new NotImplementedException();
    }

    public IInfantry CreateInfantry()
    {
        throw new NotImplementedException();
    }

    public ITrebuchet CreateTrebuchet()
    {
        throw new NotImplementedException();
    }

    public ICavalry CreateCavalry()
    {
        throw new NotImplementedException();
    }
}