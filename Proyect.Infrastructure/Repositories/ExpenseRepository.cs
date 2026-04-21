using Project.Domain.Entities;
using Project.Application.Interfaces;

namespace Project.Infrastructure.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private static readonly List<Expense> _expenses = new();

        public void AddExpense (Expense expense)
        {
            expense.Id = _expenses.Count + 1;
            _expenses.Add(expense);
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            return _expenses;
        }
    }
}
