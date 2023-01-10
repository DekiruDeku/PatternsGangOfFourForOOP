namespace ChainOfResponsibility
{
    public class FinishingWorker : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "Клеить обои")
                return "Рабочий внутренней отделки выполнил команду: " + command;
            return base.Execute(command);

        }
    }
}