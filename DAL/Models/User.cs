using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}