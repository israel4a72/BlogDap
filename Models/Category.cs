// Write for me a class of category


namespace Blog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public IEnumerable<Tag> Tags { get; set; } = Enumerable.Empty<Tag>();
    }
}