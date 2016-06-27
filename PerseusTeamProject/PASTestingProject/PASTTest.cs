namespace PASTestingProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PersonalAccountingSystem.Common.Expenses;

    class PASTTest
    {
        static void Main(string[] args)
        {
            var rakiq = new PermanentExpense("Rakiq", 5.0M, ExpenseType.Food);
            var bira = new PermanentExpense("Bira", 2.25M, ExpenseType.Food);

            Console.WriteLine(rakiq);
        }
    }
}
