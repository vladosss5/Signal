using Chat.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chat.Data.Mappings;

/// <summary>
/// Маппинг в БД модели "сообщения"
/// </summary>
public class MessageMapping : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.ToTable("Messages");
        
        builder.HasKey(e => e.Id).HasName("messages_pk");

        builder.Property(e => e.Id).HasMaxLength(37);
        builder.Property(e => e.SenderId).HasMaxLength(37);
        builder.Property(e => e.ThreadId).HasMaxLength(37);

        builder.HasOne(d => d.Sender).WithMany(p => p.Messages)
            .HasForeignKey(d => d.SenderId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("messages_users_id_fk");

        builder.HasOne(d => d.Thread).WithMany(p => p.Messages)
            .HasForeignKey(d => d.ThreadId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("messages_threads_id_fk");
    }
}