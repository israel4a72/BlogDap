namespace BlogEF.Models;

public class User
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string PasswordHash { get; private set; } = string.Empty;
    public string Image { get; private set; } = string.Empty;
    public string Slug { get; private set; } = string.Empty;
    public string Bio { get; private set; } = string.Empty;

    public ICollection<Post> Posts { get; set; } = null!;
}