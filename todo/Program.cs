using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using ToDoItems;
var items = new List<ToDo>();
bool IsNoEnd = true;
while (IsNoEnd)
{
    Console.Write("Чего желаете!? \n 1 - добавить \n 2 - показать \n 3 - удалить\n 0 - выход \n Ваш выбор: ");
    var choice = Console.ReadLine();
    switch(choice){
        case "1":
        Console.WriteLine("Название: ");
        var title = Console.ReadLine()??"";
        items.Add(new ToDo(title, false));
        break;
        case "2":
        int i = 0;
        string statMark = "";
        if (items.Count ==0){
        Console.WriteLine("список пуст");
        }
            else
            {
                foreach(var it in items){
                    i++;
                    if (it.IsDone)
                    {
                        statMark = "x";
                    }
                    Console.WriteLine($"{i}. [{statMark}] {it.Item}");
                    //Console.WriteLine($"[{(it.IsDone ? "x" : " ")}] {it.Item}");
                    
                }
            }
        break;
        case "3":
        Console.Write("Введите номер пункта для удаления: ");
        var choice1 = (Console.ReadLine());
        if (int.TryParse(choice1, out int number))
            {
                DelItem(int.Parse(choice1))1;
            }
            else
            {
                 Console.Write("Вы ввели не число!");
            }

        
        break;
        case "0":
        IsNoEnd = false;
        break;
        default:
        Console.WriteLine("Неверный ввод");
        break;

    }

    void DelItem(int num)
{
    num-=1;
    items.RemoveAt(num);
}
}