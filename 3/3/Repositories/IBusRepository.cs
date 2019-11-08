using System.Threading.Tasks;

namespace _3.Repositories
{
    /// <summary>
    /// Интерфейс репозитория автобусов.
    /// </summary>
    interface IBusRepository : IRepository<IBus>
    {
        /// <summary>
        /// Получение автобусов, назначенных на указанный маршрут. Возможно асинхронное выполнение, чтобы не подвешивать систему, так как может выполняться долго.
        /// </summary>
        /// <param name="routeId">Идентификатор маршрута, на который указаны автобусы.</param>
        /// <returns>Автобусы, назначенные на указанный маршрут.</returns>
        Task<IBus[]> GetRouteBuses(short routeId);
    }
}