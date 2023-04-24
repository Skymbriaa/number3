using System;

class Program

{

    static void Main(string[] args)

    {

        int number = 1000; // Початкове число

        while (number < 10000) // Перевіряємо всі чотиризначні числа

        {

            if (number % 133 == 125 && number % 134 == 111)

            {

                Console.WriteLine(number); // Виводимо число, яке задовольняє умови

            }

            number++;

        }

    }

}