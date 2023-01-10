using Abstract_Factory.Auto;

namespace Abstract_Factory.Factory
{
    public class FactoryOfBMV : IFactoryAuto
    {
        public ILightAuto CreateALightAuto()
        {
            return new BMVLightAuto();
        }

        public IHouseAuto CreateAHouseAuto()
        {
            return new BMVHouseAuto();
        }
    }
}