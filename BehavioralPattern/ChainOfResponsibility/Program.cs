using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        //озволяет передавать запросы последовательно по цепочке обработчиков
        // цепочка может прерываться как в случае того что обработчик не может обработать так и наоборот
        public static void Main(string[] args)
        {
            Design design = new Design();
            FinishingWorker finishingWorker = new FinishingWorker();
            Carpenter carpenter = new Carpenter();

            design.setNextWorker(carpenter).setNextWorker(finishingWorker);
            
            GiveCommand(design,"Спроектировать");
            GiveCommand(design,"Класть кирпич");
            GiveCommand(design,"Клеить обои");
            GiveCommand(design,"Убираться");
        }

        public static void GiveCommand(IWorker worker, string command)
        {
            string str = worker.Execute(command);
            if(str == "")
                Console.WriteLine(command + " никто не умеет делать");
            Console.WriteLine(str);
        }
    }
}