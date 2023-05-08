using BlogEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogDap.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                    .IsRequired()
                    .HasColumnName(nameof(User.Name))
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(80);

            builder.Property(x => x.Slug)
                    .IsRequired()
                    .HasColumnName(nameof(User.Slug))
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(80);

            builder.HasIndex(x => x.Slug, $"IX_{nameof(User)}_{nameof(User.Slug)}")
                    .IsUnique();
        }
    }
}