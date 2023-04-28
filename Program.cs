//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
//
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
//
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
//4 -> да
//-3 -> нет
//7 -> нет
//
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Привет пользователь!");
Console.WriteLine("Выбери что ты хочешь сделать:");
Console.WriteLine("Задача №1: Найти наименьшее и наибольшее из двух чисел");
Console.WriteLine("Задача №2: Найти максимальное из трех чисел");
Console.WriteLine("Задача №3: Четное или нечетное?");
Console.WriteLine("Задача №4: Все четные числа от 1 до N");
int chose;
chose = Convert.ToInt32(Console.ReadLine());
switch (chose)
{
    case 1:
        int first1;
        int second1;
        Console.WriteLine("Введите первое число:");
        first1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        second1 = Convert.ToInt32(Console.ReadLine());
        if (first1 > second1)
        {
            Console.WriteLine($"Наибольшее число {first1}, а наименьшее число {second1}");
        }
        else
        {
            Console.WriteLine($"Наибольшее число {second1}, а наименьшее число {first1}");
        }
        break;
    case 2:
        int first2;
        int second2;
        int third2;
        int max;
        Console.WriteLine("Введите первое число:");
        first2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        second2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число:");
        third2 = Convert.ToInt32(Console.ReadLine());
        if (first2 > second2)
        {
            max = first2;
        }
        else
        {
            max = second2;
        }
        if (third2 > max)
        {
            Console.WriteLine($"Наибольшее число {third2}");
        }
        else
        {
            Console.WriteLine($"Наибольшее число {max}");
        }
        break;
    case 3:
        int num;
        Console.WriteLine("Введите число для проверки");
        num = Convert.ToInt32(Console.ReadLine());
        if (num % 2==1)
        {
            Console.WriteLine($"Число {num} нечетное");
        }
        else
        {
            Console.WriteLine($"Число {num} четное");
        }
        break;
    case 4:
        int sequence;
        Console.WriteLine("Введите число N:");
        sequence = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= sequence; i++)
        if (i % 2 == 0)
        Console.WriteLine(i);
        break;
    default:
        Console.WriteLine("Выберете варианты 1-4");
        break;
}