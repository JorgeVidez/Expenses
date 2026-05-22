using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.DTOs
{
    public class CreateExpenseDto
    {
        public decimal Amount { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
