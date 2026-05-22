using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
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
            public IActionResult Create(CreateExpenseDto createExpenseDto)
            {
                _expenseService.CreateExpense(createExpenseDto);
                return Ok(createExpenseDto);
            }
        }
    
}
