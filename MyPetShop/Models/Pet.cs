using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyPetShop.Models
{
    public class Pet
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Display(Name = "Pet Name")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Pet Colour")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string Colour { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }


        [Required]
        [Display(Name = "Sound")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string Sound { get; set; }

        [Required]
        [Display(Name = "Sound Type")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string SoundType { get; set; }


        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - DateOfBirth.Year;
                if (now < DateOfBirth.AddYears(age))
                {
                    age--;
                }

                return age;
            }

        }
        public string MakeSound()
        {
            return Sound;
        }
        public virtual string MakeSoundType()
        {
            return SoundType;
        }
    }
}
