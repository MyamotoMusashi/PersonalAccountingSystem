namespace PersonalAccountingSystem.Common.Expenses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PermanentExpense : Expense
    {
        public PermanentExpense(string name, decimal value, ExpenseType type) 
            : base(name, value, type)
        {
        }
    }
}