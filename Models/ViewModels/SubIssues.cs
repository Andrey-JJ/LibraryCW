namespace LibraryCW.Models.ViewModels
{
    public class SubIssues
    {
        public Subscriber Subscriber { get; set; }
        public IEnumerable<Issue> Issues { get; set; }
    }
}
