namespace Chat.Application.Interfaces.Repositories;

public interface IBaseRepository<T> where T : class
{
    /// <summary>
    /// Добавить запись объекта.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    /// <returns>Добавленная сущность.</returns>
    public Task<T> AddAsync(T entity);
    
    /// <summary>
    /// Обновление записи объекта
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Обновлённый объект</returns>
    public Task<T> UpdateAsync(T entity);
    
    /// <summary>
    /// Удалить запись объекта.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    public Task DeleteAsync(T entity);
}