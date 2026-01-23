namespace Chat.Domain.Models;

/// <summary>
/// Доменная модель пользователя
/// </summary>
public partial class User
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string Id { get; set; } = null!;
    
    /// <summary>
    /// Имя в системе
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Логин
    /// </summary>
    public string Login { get; set; } = null!;

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = null!; // TODO: Переделать на хэширование

    /// <summary>
    /// Коллекция сообщений отправленных пользователем
    /// </summary>
    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    /// <summary>
    /// Коллекция чатов пользователя
    /// </summary>
    public virtual ICollection<UsersInChat> UsersInChats { get; set; } = new List<UsersInChat>();
}
