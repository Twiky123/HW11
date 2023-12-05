using System;
using System.Collections.Generic;

namespace Tymakov13
{
    enum BankType
    {
        текущий,
        сберегательный
    }
    internal class Bank_account
    {
        private uint number;
     
        public uint Number
        {
            get { return number; }
        }
        private BankType type;

        public BankType Type
        {
            get { return type; }
        }
        private double balance;
  
        public double Balance
        {
            get { return balance; }
        }
        private string person_holder;
  
        public string PersonHolder
        {
            set { person_holder = value; }
            get { return person_holder; }
        }
        List<BankTransaction> transactions = new List<BankTransaction>();

        public List<BankTransaction> Transactions
        {
            set { transactions = value; }
            get { return transactions; }
        }

        public BankTransaction this[int index]
        {
            get
            {
                return transactions[index];
            }
        }

        public Bank_account(uint number, BankType type, double balance, string person_holder)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
            this.person_holder = person_holder;
            GeneratNumn();
        }

        public Bank_account(uint number, BankType type, double balance)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
            person_holder = "Непон";
        }

        private void GeneratNumn()
        {
            number++;
        }

        public void PutMoney(double put_money)
        {
            BankTransaction transaction = new BankTransaction(put_money);
            transactions.Add(transaction);
            balance += put_money;
            Console.WriteLine($"Сумма баланса: {balance} рублей");
        }
   
        public void TakeoffMoney(double takeoff_money)
        {
            if (takeoff_money <= balance)
            {
                BankTransaction transaction = new BankTransaction(takeoff_money);
                transactions.Add(transaction);
                balance -= takeoff_money;
                Console.WriteLine($"Баланс сумма: {balance} рублей");
            }
            else
            {
                Console.WriteLine("Недостаточно средства");
            }
        }

        public void Transfer(double money, uint numb)
        {
            if (money <= balance)
            {
                BankTransaction transaction = new BankTransaction(money);
                transactions.Add(transaction);
                balance -= money;
                Console.WriteLine($"{person_holder} перевел(a) {money} рублей на номер карты {numb}, ваш счёт составляет {balance} рублей");
            }
            else
            {
                Console.WriteLine("Вы не можете перевести сумму, которая превышает ваш баланс");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Ваш номер: {number}\nВаш тип банковского счёта: {type}\nВаш баланс составляет: {balance}\nдержатель карты: {person_holder}");
        }
    }
}