namespace Command
{
    public class ConveyorWorkCommand : ICommand
    {
        private Conveyor _conveyor;

        public ConveyorWorkCommand(Conveyor conveyor)
        {
            _conveyor = conveyor;
        }
        
        public void Positive()
        {
            _conveyor.On();
        }

        public void Negative()
        {
            _conveyor.Off();
        }
    }
}