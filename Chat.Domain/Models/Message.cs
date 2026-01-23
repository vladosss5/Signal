namespace Chat.Domain.Models;

/// <summary>
/// Доменная модель соообщения
/// </summary>
public partial class Message
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// Содержимое
    /// </summary>
    public string Content { get; set; } = null!;

    /// <summary>
    /// Идентификатор отправителя
    /// </summary>
    public string SenderId { get; set; } = null!;
    
    /// <summary>
    /// Отправитель
    /// </summary>
    public virtual User Sender { get; set; } = null!;
    
    /// <summary>
    /// Идентификатор родительской нити
    /// </summary>
    public string ThreadId { get; set; } = null!;

    /// <summary>
    /// Родительская нить
    /// </summary>
    public virtual ThreadModel Thread { get; set; } = null!;
}
