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

                try
                {
                    _expenseService.CreateExpense(createExpenseDto);
                    return Ok(createExpenseDto);
                }
                catch (ArgumentException ex)
                {

                    return BadRequest(new { message = ex.Message });
                }
                catch (Exception) 
                {
                    return StatusCode(500, new { message = "An error occurred while creating the expense." });
                }

            
                

            }

                [HttpGet("{id}")]
                public IActionResult Get(int id)
                {
                    var expense = _expenseService.GetExpenseById(id);
                    if (expense == null)
                    {
                        return NotFound();
                    }
                    return Ok(expense);
                }

            [HttpDelete("{id}")]
                public IActionResult Delete(int id)
                {
                    try
                    {
                        _expenseService.DeleteExpenseById(id);
                        return Ok();
                    }
                    catch (KeyNotFoundException ex)
                    {
                        return NotFound(new {message = ex.Message});
                    }
                    catch(Exception)
                    {
                        return StatusCode(500, new { message = "An error occurred while deleting the expense." });
                    }
                }
        }
    
}
