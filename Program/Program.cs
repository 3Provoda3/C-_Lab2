using System;

class Program
{
    static void Main(string[] args)
    {
        int monthNumber;
        char continueChoice;

        do
        {
            bool validMonth = false;

            while (!validMonth)
            {
                // Запит на введення порядкового номера місяця
                Console.Write("Введіть порядковий номер місяця (1-12): ");
                monthNumber = Convert.ToInt32(Console.ReadLine());

                // Вивід пори року залежно від введеного номера місяця
                switch (monthNumber)
                {
                    case 1:
                    case 2:
                    case 12:
                        Console.WriteLine("Це зима.");
                        validMonth = true;
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Це весна.");
                        validMonth = true;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Це літо.");
                        validMonth = true;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Це осінь.");
                        validMonth = true;
                        break;
                    default:
                        Console.WriteLine("Введений номер місяця некоректний. Спробуйте ще раз.");
                        break;
                }
            }

            // Запитати користувача, чи хоче він продовжити
            Console.Write("Чи хочете ви продовжити? (y/n): ");
            continueChoice = Convert.ToChar(Console.ReadLine().ToLower());

        } while (continueChoice == 'y');

        Console.WriteLine("Програма завершена.");
    }
}
