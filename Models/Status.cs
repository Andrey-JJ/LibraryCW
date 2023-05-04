using System.ComponentModel.DataAnnotations;

namespace LibraryCW.Models
{
    public class Status
    {
        public int Id { get; set; }
        [Display(Name = "Название статуса")]
        public string Type { get; set; }
    }
}
