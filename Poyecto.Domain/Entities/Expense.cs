using System.Runtime;

namespace Project.Domain.Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public string Category { get; set; } = "General";
    }
}
