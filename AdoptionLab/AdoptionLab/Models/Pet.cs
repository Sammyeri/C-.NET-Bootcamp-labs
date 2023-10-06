using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdoptionLab.Models
{
    public class Pet
    {
        public int Id { get; set; }

        [Required]
        public int Age { get; set; }

        [Column(TypeName ="varchar(20)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Species { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Breed { get; set; }


        [Column(TypeName = "text")]
        [Required]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        [Required]
        public string Image{ get; set; }

    }
}
