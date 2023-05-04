using System.ComponentModel.DataAnnotations;

namespace LibraryCW.Models
{
    public class Edition
    {
        public int Id { get; set; }
        [Display(Name = "Название издательства")]
        public string Name { get; set; }
    }
}
