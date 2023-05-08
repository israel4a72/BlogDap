using System.Diagnostics;

namespace BlogEF.Models
{
    public class Post
    {
        public int Id { get; private set; }

        public int CategoryId { get; private set; }
        public int AuthorId { get; private set; }
        public string Title { get; private set; } = string.Empty;
        public string Summary { get; private set; } = string.Empty;
        public string Body { get; private set; } = string.Empty;
        public string Slug { get; private set; } = string.Empty;
        public string Image { get; private set; } = string.Empty;
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }

        public User Author { get; set; } = null!;
        public Category Category { get; set; } = null!;
        public IEnumerable<Tag> Tags { get; set; } = null!;
    }
}