using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces;
using Project.Domain.Entities;
using Project.Infrastructure.Repositories;

namespace Project.Api.Controllers
{
    
        [ApiController]
        [Route("api/[controller]")]
        public class ExpenseController : ControllerBase
        {
            private readonly IExpenseRepository _expenseRepository;


            public ExpenseController(IExpenseRepository expenseRepository)
            {
                _expenseRepository = expenseRepository;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
               return Ok(_expenseRepository.GetAllExpenses());
            }

            [HttpPost]
            public IActionResult Create(Expense expense)
            {
                _expenseRepository.AddExpense(expense);
                return Ok(expense);
            }
        }
    
}
