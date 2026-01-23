using Chat.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chat.Data.Mappings;

/// <summary>
/// Маппинг в БД модели "связка пользователей и чатов"
/// </summary>
public class UsersInChatMapping : IEntityTypeConfiguration<UsersInChat>
{
    public void Configure(EntityTypeBuilder<UsersInChat> builder)
    {
        builder.HasKey(e => e.Id).HasName("usersinchats_pk");

        builder.ToTable("UsersInChats");

        builder.Property(e => e.Id).HasMaxLength(37);
        builder.Property(e => e.ChatId).HasMaxLength(37);
        builder.Property(e => e.UserId).HasMaxLength(37);

        builder.HasOne(d => d.ChatModel).WithMany(p => p.UsersInChats)
            .HasForeignKey(d => d.ChatId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("usersinchats_chats_id_fk");

        builder.HasOne(d => d.User).WithMany(p => p.UsersInChats)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("usersinchats_users_id_fk");
    }
}