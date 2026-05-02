using Project.Domain.Entities;

namespace Project.Application.Interfaces
{
    public interface IExpenseRepository
    {
        IEnumerable<Expense> GetAllExpenses();
        void AddExpense(Expense expense);
         
    }
}
