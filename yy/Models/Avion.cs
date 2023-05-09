using System.ComponentModel.DataAnnotations;

namespace yy.Models
{
    public class Avion
    {
        public int BrandId { get; set; }

        [Required(ErrorMessage = "La marca es requerida!")]
        [Display(Name = "Marca")]
        public string MarcaName { get; set; }

        // public ICollection<Instructor> InstructorList { get; set; } = new List<Instructor>();
    }
}