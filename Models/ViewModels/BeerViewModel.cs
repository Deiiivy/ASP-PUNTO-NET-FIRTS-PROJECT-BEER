using System.ComponentModel.DataAnnotations;

namespace Beer.Models.ViewModels
{
    public class BeerViewModel
    {

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Marca")]
        public int BranId { get; set; }
    }
}
