using Project.Application.DTOs;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Interfaces
{
    public interface IExpenseService
    {
        void CreateExpense(CreateExpenseDto createExpenseDto);
        IEnumerable<ExpenseDto> GetHistoryExpenses();
    }
}
