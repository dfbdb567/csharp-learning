bool IsNoEnd = true;
while (IsNoEnd)
{
    Console.Write("Добро пожаловать рестран! \n 1 - добавить \n 2 - показать \n 0 - выход \n Ваш выбор: ");
    var choice = Console.ReadLine();
    switch(choice){
        case "1":
        Console.WriteLine("добавление будет позже");
        break;
        case "2":
        Console.WriteLine("список пуст");
        break;
        case "0":
        IsNoEnd = false;
        break;
        default:
        Console.WriteLine("Неверный ввод");
        break;

    }
}