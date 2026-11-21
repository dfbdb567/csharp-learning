
using ToDoItems;
using UTI;
var items = new List<ToDo>();
var todo = new TodoList();
bool IsNoEnd = true;
while (IsNoEnd)
{
    Console.Write("Чего желаете!? \n 1 - добавить \n 2 - показать \n 3 - удалить\n 4 - отметить выполненой\n 0 - выход \n Ваш выбор: ");
    var choice = Console.ReadLine();
    switch(choice){
        case "1":
        Console.WriteLine("Название: ");
        var title = Console.ReadLine()??"";
        Console.WriteLine("Срочная?[да/нет]\n");
        string ungret  = Console.ReadLine()??"";
        if(ungret.ToLower() =="нет" || ungret.ToLower() == "да"){
        bool Urgent = (ungret.ToLower() == "да");
        todo.AddItem(title,Urgent);
        }
        else
        {
            Console.WriteLine("Некоректный ввод!!!!");
        }
           
        break;
         case "2":
            if (todo.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            else
            {
                
                for (int i = 0; i < todo.Count; i++)
                {
        
                    Console.WriteLine($"{i + 1}. {todo.GetAt(i).Describe()}");
                }
            }
            break;
        case "3":
        Console.Write("Введите номер пункта для удаления: ");
        var choice1 = (Console.ReadLine());
        if (int.TryParse(choice1, out int number) )
            {
               if (todo.Remove(number))
                {
                Console.WriteLine("Удалено");
                }
                else
                {
                    Console.WriteLine("Что-то пошло не так");
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
                if (todo.ToggleDone(num))
                {
                    Console.WriteLine("Отмечено");
                }
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


}