using Chat.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Chat.Data.Context;

/// <summary>
/// Контекст БД
/// </summary>
public partial class SignalDBContext : DbContext
{
    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    public SignalDBContext()
    {
    }

    /// <summary>
    /// Конструктор с параметрами запуска
    /// </summary>
    /// <param name="options"></param>
    public SignalDBContext(DbContextOptions<SignalDBContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Чаты
    /// </summary>
    public virtual DbSet<ChatModel> Chats { get; set; }

    /// <summary>
    /// Сообщения
    /// </summary>
    public virtual DbSet<Message> Messages { get; set; }

    /// <summary>
    /// Нити
    /// </summary>
    public virtual DbSet<ThreadModel> Threads { get; set; }

    /// <summary>
    /// Пользователи
    /// </summary>
    public virtual DbSet<User> Users { get; set; }

    /// <summary>
    /// Связь чатов и пользователей
    /// </summary>
    public virtual DbSet<UsersInChat> UsersInChats { get; set; }
    

    /// <summary>
    /// Конфигурация строки подключения (только для локального использования)
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=localhost;port=5418;user id=postgres;password=1234;database=SignalDB;");
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
