using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BudgetAccounting
{
    public class Budget
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Ammount { get; set; }
        public bool IsIncome { get; set; }
        public DateTime CurrentDate;

        public Budget(DateTime entryDate, string entryName, string entryType, int entryMoney, bool isIncome)
        {
            CurrentDate = entryDate;
            Name = entryName;
            Type = entryType;
            Ammount = entryMoney;
            IsIncome = isIncome;
        }
    }
}
