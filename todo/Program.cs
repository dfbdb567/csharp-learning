using ToDoItems;

ITodoList todo = new TodoList();
bool IsNoEnd = true;

while (IsNoEnd)
{
    Console.Write("Чего желаете!? \n 1 - добавить \n 2 - показать \n 3 - удалить\n 4 - отметить выполненой\n 0 - выход \n Ваш выбор: ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Название: ");
            var title = Console.ReadLine() ?? "";
            Console.WriteLine("Срочная?[да/нет]\n");
            var answer = (Console.ReadLine() ?? "").Trim().ToLower();

            if (answer == "да" || answer == "нет")
            {
                todo.AddItem(title, answer == "да");
                Console.WriteLine("Добавлено");
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
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
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Это не число");
                break;
            }

            Console.WriteLine(todo.Remove(number) ? "Удалено" : "Нет такой задачи");
            break;

        case "4":
            Console.Write("Что выделить выполненным?: ");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Это не число");
                break;
            }

            Console.WriteLine(todo.ToggleDone(num) ? "Отмечено" : "Нет такой задачи");
            break;

        case "0":
            IsNoEnd = false;
            break;

        default:
            Console.WriteLine("Неверный ввод");
            break;
    }
}
