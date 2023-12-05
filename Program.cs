using System;

namespace Tymakov13
{
    internal class Program
    {
        public static object ConvertToDouble { get; private set; }

        static void Main()
        {

            Console.WriteLine("Лабораторная работа 13");
            Console.WriteLine("Добавить свойство для чтения и записи типа string для отображения поля держатель" +
                                "Банковского счета.Изменить класс BankTransaction, созданный для хранений финансовых"+
                                "операций со счетом, -заменить методы доступа к данным на свойства для чтения.");
            Console.WriteLine("вВЕДИТЕ БАЛНС");
            double n = Convert.ToDouble(Console.ReadLine());
            Bank_account bank = new Bank_account(123, BankType.текущий, 0, "NName");
            Console.WriteLine($"На вашем {BankType.текущий} счёте {n} рублей"); Console.WriteLine("{0, 85}");
            Console.WriteLine("Подсказка:\n" +
                              "Положить деньги на счет   -   цифра 1\n" +
                              "Снять деньги со счета  -   цифра 2\n" +
                              "Перевести деньги на другую карту  -   цифра 0\n");


            bool flag = int.TryParse(Console.ReadLine(), out int tasknum);
            if (flag)
            {
                switch (tasknum)
                {
                    case 1:
                        Console.Write("Напишите сумму, которую хотите положить: ");
                        bool flag1 = double.TryParse(Console.ReadLine(), out double put_money);
                        if (flag1)
                        {
                            bank.PutMoney(put_money);
                        }
                        else
                        {
                            Console.WriteLine("Введите целое неотриц число");
                        }
                        Console.WriteLine(bank[0].Print());
                        break;
                    case 2:
                        Console.Write("Напишите сумму, которую хотите снять: ");
                        bool flag2 = double.TryParse(Console.ReadLine(), out double takeoff_money);
                        if (flag2)
                        {
                            bank.TakeoffMoney(takeoff_money);
                        }
                        else
                        {
                            Console.WriteLine("Введите целое неотриц число");
                        }
                        Console.WriteLine(bank[0].Print());
                        break;
                    case 3:
                        Console.Write("Напишите сумму, которую хотите перевести на другую карту: ");
                        bool flag3 = double.TryParse(Console.ReadLine(), out double money);
                        Console.Write("Введите номер карты: ");
                        bool flag4 = uint.TryParse(Console.ReadLine(), out uint numb);
                        if (flag3 && flag4)
                        {
                            bank.Transfer(money, numb);
                        }
                        else
                        {
                            Console.WriteLine("Введите целое неотриц");
                        }
                        Console.WriteLine(bank[0].Print());
                        break;
                    default:
                        Console.WriteLine("Выберите команду");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Такой команды не существует");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 13.1 и 13.2");


            Console.WriteLine();
            Build build = new Build();
            build.Collection(new Collectionsofbuildings(1, 2, 3, 4));
            build.Collection(new Collectionsofbuildings(2, 3, 4, 5));
            build.Collection(new Collectionsofbuildings(3, 4, 5, 6));
            build.Collection(new Collectionsofbuildings(4, 5, 6, 7));
            build.Collection(new Collectionsofbuildings(5, 6, 7, 8));
            build.Collection(new Collectionsofbuildings(6, 7, 8, 9));
            build.Collection(new Collectionsofbuildings(7, 8, 9, 10));
            build.Collection(new Collectionsofbuildings(8, 9, 10, 11));
            build.Collection(new Collectionsofbuildings(9, 10, 11, 12));
            build.Collection(new Collectionsofbuildings(10, 11, 12, 13));
            for (int i = 0; i < build.Builds.Length; i++)
            {
                Console.WriteLine($"Номер здания: {build[i].Number}" +
                    $"Высота здания: {build[i].Height}" +
                    $"Количество этажей: {build[i].Floor}" +
                    $"Количество квартир: {build[i].Aparuaments}" +
                    $"Количество подъездов: {build[i].Entry}");
                Console.WriteLine();
            }

            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}