using Chat.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chat.Data.Mappings;

/// <summary>
/// Маппинг в БД модели "тред"
/// </summary>
public class ThreadModelMapping : IEntityTypeConfiguration<ThreadModel>
{
    public void Configure(EntityTypeBuilder<ThreadModel> builder)
    {
        builder.HasKey(e => e.Id).HasName("threads_pk");

        builder.ToTable("Threads");

        builder.Property(e => e.Id).HasMaxLength(37);
        builder.Property(e => e.ChatId).HasMaxLength(37);

        builder.HasOne(d => d.ChatModel).WithMany(p => p.Threads)
            .HasForeignKey(d => d.ChatId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("threads_chats_id_fk");
    }
}