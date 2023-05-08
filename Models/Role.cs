namespace BlogEF.Models
{
    public class Role
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Slug { get; private set; } = string.Empty;
        public IEnumerable<User> Users { get; private set; } = Enumerable.Empty<User>();
    }
}