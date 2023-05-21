// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
    int number = int.Parse(Console.ReadLine());

    int originalNumber = number;  // Сохраняем оригинальное число для сравнения

    int reverseNumber = 0;  // Извлекаем цифры из числа и формируем новое число в обратном порядке
        while (number != 0)
        {
            int digit = number % 10;
            reverseNumber = reverseNumber * 10 + digit;
            number /= 10;
        }

        if (originalNumber == reverseNumber)
            Console.WriteLine("Да, число является палиндромом");
            
        else
            Console.WriteLine("Нет, число не является палиндромом");

        Console.ReadLine();