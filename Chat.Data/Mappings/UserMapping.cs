using Chat.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chat.Data.Mappings;

/// <summary>
/// Маппинг в БД модели "пользователь"
/// </summary>
public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(e => e.Id).HasName("users_pk");

        builder.Property(e => e.Id).HasMaxLength(37);
        builder.Property(e => e.Login).HasMaxLength(30);
        builder.Property(e => e.Name).HasMaxLength(50);
        builder.Property(e => e.Password).HasMaxLength(30);
    }
}