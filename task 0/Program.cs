// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49c

Console.WriteLine("Введите число1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2");
int number2 = Convert.ToInt32(Console.ReadLine());
 
 if (number1 == number2 * number2)
    Console.WriteLine("Yes");
    else
    Console.WriteLine("No");

