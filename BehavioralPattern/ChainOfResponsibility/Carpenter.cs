namespace ChainOfResponsibility
{
    public class Carpenter : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "Класть кирпич")
                return "Плотник выполнил команду: " + command;
            return base.Execute(command);
        }
    }
}