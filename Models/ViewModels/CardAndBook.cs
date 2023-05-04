namespace LibraryCW.Models.ViewModels
{
    public class CardAndBook
    {
        public CatalogCard CatalogCard { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
