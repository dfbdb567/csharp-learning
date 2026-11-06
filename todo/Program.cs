using System.Data.Common;
using ToDoItems;
var items = new List<ToDo>();
bool IsNoEnd = true;
while (IsNoEnd)
{
    Console.Write("Чего желаете!? \n 1 - добавить \n 2 - показать \n 0 - выход \n Ваш выбор: ");
    var choice = Console.ReadLine();
    switch(choice){
        case "1":
        Console.WriteLine("Название: ");
        var title = Console.ReadLine()??"";
        items.Add(new ToDo(title, false));
        break;
        case "2":
        if (items.Count ==0){
        Console.WriteLine("список пуст");
        }
            else
            {
                foreach(var it in items){
                    Console.WriteLine($"[{(it.IsDone ? "x" : " ")}] {it.Item}");
                }
            }
        break;
        case "0":
        IsNoEnd = false;
        break;
        default:
        Console.WriteLine("Неверный ввод");
        break;

    }
}