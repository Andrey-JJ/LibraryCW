namespace LibraryCW.Models.ViewModels
{
    public class BookIssues
    {
        public Book Book { get; set; }
        public IEnumerable<Issue> Issues { get; set; }
    }
}
