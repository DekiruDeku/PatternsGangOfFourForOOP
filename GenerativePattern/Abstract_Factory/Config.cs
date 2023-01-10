using Abstract_Factory.Auto;
using Abstract_Factory.Factory;

namespace Abstract_Factory
{
    public class Config
    {
        // Код, использующий фабрику, не волнует с какой конкретно
        // фабрикой он работает. Все получатели продуктов работают с
        // продуктами через абстрактный интерфейс. Поэтому тут есть пример под названием Config
        private IFactoryAuto _factoryAuto;
        private ILightAuto _lightAuto;
        private IHouseAuto _houseAuto;

        public Config(IFactoryAuto factoryAuto)
        {
            _factoryAuto = factoryAuto;
        }

        public void CreateALightAuto()
        {
            _lightAuto = _factoryAuto.CreateALightAuto();
        }

        public void CreateAHouseAuto()
        {
            _houseAuto = _factoryAuto.CreateAHouseAuto();
        }
    }
}