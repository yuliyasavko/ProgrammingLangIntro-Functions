while(true)
{
    Console.WriteLine("Введите целое число. Для завершения введите 'q' или число, в которм сумма цифр четная");
    string input = Console.ReadLine();

    if (input.ToLower() == "q")
    {
        Console.WriteLine("Программа завершена");
        break;
    }
    int number; 
    if (int.TryParse(input, out number))
    {
        int sum = 0;
        while(number > 0)
        {
            int digit = number % 10;
            sum = sum + digit;
            number = number / 10;
        }
        if (sum % 2 == 0) 
        {
            Console.WriteLine("Программа завершена");
            break;
        }
    }
    else 
    {
        Console.WriteLine($"Введенная строка {input} не является числом");
    }
}

