using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("Payments")]
    public class Payment
    {
        public int Id { get; set; }
        public bool IsIncome { get; set; }
        public DateTime DateCreated { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
    }
}
