using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Project.Application.DTOs
{
    public class CreateExpenseDto
    {
        [Required(ErrorMessage = "The amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The amount must be greater than zero.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "The description is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "The description must be between 3 and 100 characters.")]
        public string Description { get; set; } = string.Empty;
    }
}
