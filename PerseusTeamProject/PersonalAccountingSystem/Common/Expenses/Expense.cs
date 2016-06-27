namespace PersonalAccountingSystem.Common.Expenses
{
    using System;
    using System.Text;

    public abstract class Expense
    {
        private string name;
        private decimal price;
        private ExpenseType type;

        public Expense(string name, decimal price, ExpenseType type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                //// TODO: Implement validation
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                //// TODO: Implement validation
                this.price = value;
            }
        }

        public ExpenseType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                //// TODO: Implement validation
                this.type = value;
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo.AppendFormat("Name {0}{1}", this.Name, Environment.NewLine);
            printInfo.AppendFormat("Price {0:c}{1}", this.Price, Environment.NewLine);
            printInfo.AppendFormat("Type {0}", this.Type);

            return printInfo.ToString();
        }
    }
}