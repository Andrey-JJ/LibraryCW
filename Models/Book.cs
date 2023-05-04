using System.ComponentModel.DataAnnotations;

namespace LibraryCW.Models
{
    public class Book
    {
        // Основная информация
        public int Id { get; set; }
        public int CatalogCardId { get; set; }
        [Display(Name = "Название книги")]
        public CatalogCard? CatalogCard { get; set; }
        public int StatusId { get; set; }
        [Display(Name = "Состояние книги")]
        public Status? BookStatus { get; set; } // "Выдана", "Забронирована", "Не выдана"
    }
}
