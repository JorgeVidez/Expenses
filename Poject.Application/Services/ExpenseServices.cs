using Project.Application.DTOs;
using Project.Application.Interfaces;
using Project.Domain.Entities;

namespace Project.Application.Services
{
    public class ExpenseServices : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;
        public ExpenseServices(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public void CreateExpense(CreateExpenseDto createExpenseDto)
        {
            if (createExpenseDto.Amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(createExpenseDto.Description))
            {
                throw new ArgumentException("Description cannot be empty.");
            }

            var expense = new Expense
            {
                Amount = createExpenseDto.Amount,
                Description = createExpenseDto.Description,
                Date = DateTime.Now
            };
            _expenseRepository.AddExpense(expense);


        }
        public IEnumerable<ExpenseDto> GetHistoryExpenses()
        {
            var entities = _expenseRepository.GetAllExpenses();

            return entities.Select(expenseDto => new ExpenseDto
            {
                Id = expenseDto.Id,
                Amount = expenseDto.Amount,
                Description = expenseDto.Description,
                Date = expenseDto.Date,
            }).ToList();


        }
    }
}
