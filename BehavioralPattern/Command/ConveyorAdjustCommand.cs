namespace Command
{
    public class ConveyorAdjustCommand : ICommand
    {
        private Conveyor _conveyor;

        public ConveyorAdjustCommand(Conveyor conveyor)
        {
            _conveyor = conveyor;
        }
        
        public void Positive()
        {
            _conveyor.SpeedIncrease();
        }

        public void Negative()
        {
            _conveyor.SpeedDincrease();
        }
    }
}