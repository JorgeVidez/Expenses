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
            private readonly IExpenseService _expenseService;


            public ExpenseController(IExpenseService expenseService)
            {
                _expenseService = expenseService;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
               return Ok(_expenseService.GetHistoryExpenses());
            }

            [HttpPost]
            public IActionResult Create(Expense expense)
            {
                _expenseService.CreateExpense(expense);
                return Ok(expense);
            }
        }
    
}
