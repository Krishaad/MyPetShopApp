using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyPetShop.Models
{
    public class Cat : Pet
    {
        [Required]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Cat Breed")]
        [MinLength(3)]
        public string Breed { get; set; }
    }
}
