using Abstract_Factory.Auto;

namespace Abstract_Factory.Factory
{
    public interface IFactoryAuto
    {
        ILightAuto CreateALightAuto();

        IHouseAuto CreateAHouseAuto();
    }
}