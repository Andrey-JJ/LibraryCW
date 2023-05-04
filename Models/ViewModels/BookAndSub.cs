namespace LibraryCW.Models.ViewModels
{
    public class BookAndSub
    {
        public int CardId { get; set; }
        public Book book { get; set; }
        public IEnumerable<Subscriber> Subscribers { get; set; }
    }
}
