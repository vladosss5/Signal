namespace Chat.Domain.Models;

/// <summary>
/// Доменная модель нитей
/// </summary>
public partial class ThreadModel
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// Идентификатор родительского чата
    /// </summary>
    public string ChatId { get; set; } = null!;
    
    /// <summary>
    /// Родительский чат
    /// </summary>
    public virtual ChatModel ChatModel { get; set; } = null!;

    /// <summary>
    /// Нить является главной в чате?
    /// </summary>
    public bool IsMain { get; set; }

    /// <summary>
    /// Коллекция сообщений в нити
    /// </summary>
    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}
