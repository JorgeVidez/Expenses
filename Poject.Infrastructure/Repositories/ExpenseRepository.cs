using Project.Domain.Entities;
using Project.Application.Interfaces;
using Project.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Project.Infrastructure.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly ApplicationDbContext _context;

        public ExpenseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddExpense (Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            return _context.Expenses.AsNoTracking().ToList();
        }
    }
}
