using System.ComponentModel.DataAnnotations;

namespace LibraryCW.Models
{
    public class Department
    {
        // Основная информация
        public int Id { get; set; }
        [Display(Name = "Название отдела")]
        public string Name { get; set; }
    }
}
