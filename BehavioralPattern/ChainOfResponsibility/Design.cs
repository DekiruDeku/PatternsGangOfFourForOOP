namespace ChainOfResponsibility
{
    public class Design : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "Спроектировать")
                return "Проектировщик выполнил команду: " + command;
            return base.Execute(command);

        }
    }
}