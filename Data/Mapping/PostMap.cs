using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogDap.Data.Mapping
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Post> builder)
        {
            builder.ToTable(nameof(Post));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Title)
                    .IsRequired()
                    .HasColumnName(nameof(Post.Title))
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(80);

            builder.Property(x => x.Slug)
                    .IsRequired()
                    .HasColumnName(nameof(Post.Slug))
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(80);

            builder.Property(x => x.LastUpdateDate)
                    .IsRequired()
                    .HasColumnName(nameof(Post.LastUpdateDate))
                    .HasColumnType("SMALLDATETIME")
                    .HasDefaultValue(DateTime.Now.ToUniversalTime());

            builder.HasOne(x => x.Author)
                .WithMany(x => x.Posts)
                .HasConstraintName($"FK_{nameof(Post)}_{nameof(Post.Author)}")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Posts)
                .HasConstraintName($"FK_{nameof(Post)}_{nameof(Post.Category)}")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Tags)
                .WithMany(x => x.Posts)
                .UsingEntity(Disctionary<string, string>);

            builder.HasIndex(x => x.Slug, $"IX_{nameof(Post)}_{nameof(Post.Slug)}")
                    .IsUnique();
        }
    }
}