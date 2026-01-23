using Chat.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chat.Data.Mappings;

/// <summary>
/// Маппинг в БД модели "чат"
/// </summary>
public class ChatModelMapping : IEntityTypeConfiguration<ChatModel>
{
    public void Configure(EntityTypeBuilder<ChatModel> builder)
    {
        builder.HasKey(e => e.Id).HasName("chat_pk");

        builder.ToTable("Chats");

        builder.Property(e => e.Id).HasMaxLength(37);
        builder.Property(e => e.Name).HasMaxLength(50);
    }
}