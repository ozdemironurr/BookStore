using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RefresToken { get; set; }
        public DateTime RefreshTokenExpDate { get; set; }
    
    }
}
