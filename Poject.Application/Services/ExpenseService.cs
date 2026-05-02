using Project.Application.Interfaces;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Services
{
    public class ExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;
        public void CreateExpense(Expense expense)
        {
            if (expense.Amount <=  0)
            {
                throw new ArgumentException("Amount must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(expense.Description))
            {
                throw new ArgumentException("Description cannot be empty.");
            }

            expense.Date = DateTime.Now;
            _expenseRepository.AddExpense(expense);
        }
    }
}
