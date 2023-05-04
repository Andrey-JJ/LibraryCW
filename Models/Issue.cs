﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryCW.Models
{
    public class Issue
    {
        // Основная информация
        public int Id { get; set; }
        public int BookId { get; set; }
        [Display(Name = "Название книги")]
        public Book? Book { get; set; }
        public int SubscriberId { get; set; }
        [Display(Name = "Читатель")]
        public Subscriber? Subscriber { get; set; }
        public int LibrarianId { get; set; }
        [Display(Name = "Библиотекарь")]
        public Librarian? Librarian { get; set; }
        [Display(Name = "Дата выдачи")]
        public DateTime IssueDate { get; set; }
        [Display(Name = "Дата возврата")]
        public DateTime ReturnDate { get; set; }
    }
}
