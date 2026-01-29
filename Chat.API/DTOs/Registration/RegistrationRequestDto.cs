namespace Chat.API.DTOs.Registration;

public class RegistrationRequestDto
{
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
    public string Password { get; set; } = null!;
}