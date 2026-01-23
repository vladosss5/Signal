namespace Chat.Domain.Models;

/// <summary>
/// Пользователи в чате
/// </summary>
public partial class UsersInChat
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public string UserId { get; set; } = null!;
    
    /// <summary>
    /// Пользователь
    /// </summary>
    public virtual User User { get; set; } = null!;

    /// <summary>
    /// Идентификатор чата
    /// </summary>
    public string ChatId { get; set; } = null!;

    /// <summary>
    /// Чат
    /// </summary>
    public virtual ChatModel ChatModel { get; set; } = null!;
}
