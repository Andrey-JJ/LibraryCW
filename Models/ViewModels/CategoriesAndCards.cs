namespace LibraryCW.Models.ViewModels
{
    public class CategoriesAndCards
    {
        public Department Categorie {  get; set; }
        public IEnumerable<CatalogCard> Books { get; set; }
    }
}
