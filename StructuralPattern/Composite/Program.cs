using System;

namespace Composite
{
    internal class Program
    {
        // Компоновщик один из двух паттернов использующиъ обратную вложенность
        // представленного в виде дерева от частного к целому(от корня к листьям)
        // Пример постоен на представлении меню
        public static void Main(string[] args)
        {
            Item file = new DropDownItem("Файл->");
            Item create = new DropDownItem("Создать->");
            Item open = new DropDownItem("Открыть->");

            Item exit = new ClickableItem("Выход");
            
            file.Add(create);
            file.Add(open);
            file.Add(exit);

            Item project = new ClickableItem("Проееект: ");
            Item repository = new ClickableItem("Репозиторий: ");
            
            create.Add(project);
            create.Add(repository);
            
            Item solution = new ClickableItem("Решение: ");
            Item folder = new ClickableItem("Папка: ");
            
            open.Add(solution);
            open.Add(folder);
            
            file.Display();
            Console.WriteLine();
            
            file.Remove(create);
            file.Display();
        }
    }
}