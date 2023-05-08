namespace BlogEF.Models
{
    public class Tag
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Slug { get; private set; } = string.Empty;

        public IEnumerable<Post> Posts { get; private set; } = Enumerable.Empty<Post>();
    }
}