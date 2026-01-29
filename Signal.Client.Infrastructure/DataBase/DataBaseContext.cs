using Microsoft.EntityFrameworkCore;
using Signal.Client.Core.DataBaseModels;

namespace Signal.Client.Infrastructure.DataBase;

/// <summary>
/// Контекст для работы с базой̆ данных.
/// </summary>
public class DataBaseContext : DbContext
{
    /// <summary>
    /// Конструктор.
    /// </summary>
    public DataBaseContext()
    { }
    
    /// <summary>
    /// Конструктор-перегрузка с опциями.
    /// </summary>
    /// <param name="options">Опции контекста.</param>
    public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
    { }
    
    public DbSet<Account> Accounts { get; set; }
    
    
}