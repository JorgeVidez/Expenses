using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.DTOs
{
    public class ExpenseDto
    {
        public int Id { get; set; }

        public string? Description { get; set; } 

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

    }
}
