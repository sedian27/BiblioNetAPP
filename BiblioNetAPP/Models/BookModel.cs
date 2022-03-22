using BiblioNetAPP.Validations;
using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]
        public string BookName { get; set; }
        public int Author { get; set; }
        public double Price { get; set; }
    }
}
