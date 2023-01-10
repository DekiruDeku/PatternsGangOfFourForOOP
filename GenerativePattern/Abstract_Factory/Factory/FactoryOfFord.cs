using Abstract_Factory.Auto;

namespace Abstract_Factory.Factory
{
    public class FactoryOfFord : IFactoryAuto
    {
        public ILightAuto CreateALightAuto()
        {
            return new FordLightAuto();
        }

        public IHouseAuto CreateAHouseAuto()
        {
            return new FordHouseAuto();
        }
    }
}