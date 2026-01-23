namespace Chat.Domain.Models;

/// <summary>
/// Доменная модель чата
/// </summary>
public partial class ChatModel
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Связка с нитями
    /// </summary>
    public virtual ICollection<ThreadModel> Threads { get; set; } = new List<ThreadModel>();

    /// <summary>
    /// Связка с пользователями
    /// </summary>
    public virtual ICollection<UsersInChat> UsersInChats { get; set; } = new List<UsersInChat>();
}
