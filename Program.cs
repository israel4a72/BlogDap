using BlogDap.Data;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();
var posts = await context.Posts.FirstOrDefaultAsync();
var users = await context.Users.ToListAsync();

Console.WriteLine(posts);