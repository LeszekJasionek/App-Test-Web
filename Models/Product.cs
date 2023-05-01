using System.ComponentModel.DataAnnotations;

namespace App_Test_Web.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Het veld 'Name' is verplicht ")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
