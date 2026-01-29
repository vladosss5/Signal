namespace Signal.Client.Core.DataBaseModels;

/// <summary>
/// Модель аккаунта.
/// </summary>
public class Account : ModelBaseId
{
    /// <summary>
    /// Логин.
    /// </summary>
    public string Login { get; set; } = null!;
    
    /// <summary>
    /// Пароль.
    /// </summary>
    public string Password { get; set; } = null!;
    
    /// <summary>
    /// Токен авторизации.
    /// </summary>
    public string? Jwt { get; set; }
}