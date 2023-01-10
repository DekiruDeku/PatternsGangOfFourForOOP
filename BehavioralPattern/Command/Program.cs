namespace Command
{
    internal class Program
    {
        // который превращает запросы в объекты, позволяя
        // передавать их как аргументы при вызове методов, ставить
        // запросы в очередь, логировать их, а также поддерживать
        // отмену операций.
        
        // один из объектов интерфейса напрямую вызывает метод одного из объектов
        // бизнес-логики, передавая в него какие-то параметры.
        
        public static void Main(string[] args)
        {
            Conveyor conveyor = new Conveyor();
            Multipult multipult = new Multipult();
            
            multipult.SetCommand(0, new ConveyorWorkCommand(conveyor));
            multipult.SetCommand(1, new ConveyorAdjustCommand(conveyor));
            
            multipult.PressOn(0);
            multipult.PressOn(1);
            
            multipult.PressCancel();
            multipult.PressCancel();
        }
    }
}