
using ToDoItems;
var items = new List<ToDo>();
bool IsNoEnd = true;
while (IsNoEnd)
{
    Console.Write("Чего желаете!? \n 1 - добавить \n 2 - показать \n 3 - удалить\n 4 - отметить выполненой\n 0 - выход \n Ваш выбор: ");
    var choice = Console.ReadLine();
    switch(choice){
        case "1":
        Console.WriteLine("Название: ");
        var title = Console.ReadLine()??"";
        items.Add(new ToDo(title, false));
        break;
        case "2":
        int i = 0;
        if (items.Count ==0){
        Console.WriteLine("список пуст");
        }
            else
            {
                foreach(var it in items){
                    i++;
                    string statMark = "";
                    if (it.IsDone)
                    {
                        statMark = "x";
                    }
                    Console.WriteLine($"{i}. [{statMark}] {it.Item}");
                    
                    
                }
            }
        break;
        case "3":
        Console.Write("Введите номер пункта для удаления: ");
        var choice1 = (Console.ReadLine());
        if (int.TryParse(choice1, out int number) )
            {
                if(number <=(items.Count) && number>0){
                DelItem(number);
                Console.WriteLine("Удалено");}
                else
                {
                    Console.WriteLine("Вы вышли за пределы списка");
                }
            }
            else
            {
                 Console.WriteLine("Введите число в рамках списка!");
            }

        
        break;
        case "4":
        Console.Write("Что выделить выполненым?: ");
        var choice2 = (Console.ReadLine());
        if (int.TryParse(choice2, out int num) )
            {
                if(num <=(items.Count) && num>0){
                items[num-1].IsDone= !items[num-1].IsDone;
                Console.WriteLine("Отмечено");}
                else
                {
                    Console.WriteLine("Вы вышли за пределы списка");
                }
                
            }
            else
            {
                 Console.Write("Введите число в рамках списка!");
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