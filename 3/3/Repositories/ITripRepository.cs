using System;
using System.Threading.Tasks;

namespace _3.Repositories
{
    public interface ITripRepository : IRepository<ITrip>
    {
        /// <summary>
        /// Получение рейсов за указанный период. Возможно асинхронное выполнение, чтобы не подвешивать систему, так как может выполняться долго.
        /// </summary>
        /// <param name="fromDate">Дата, начиная с которой отобрать рейсы.</param>
        /// <param name="toDate">Дата, по которую отобрать рейсы.</param>
        /// <returns>Рейсы за указанный период.</returns>
        Task<ITrip[]> GetTrips(DateTime fromDate, DateTime toDate);

        /// <summary>
        /// Получение рейсов за указанный период для указанного автобуса.
        /// Возможно асинхронное выполнение, чтобы не подвешивать систему, так как может выполняться долго.
        /// </summary>
        /// <param name="fromDate">Дата, начиная с которой отобрать рейсы.</param>
        /// <param name="toDate">Дата, по которую отобрать рейсы.</param>
        /// <param name="busId">Идентификатор автобуса, рейсы которого отобрать.</param>
        /// <returns>Рейсы за указанный период для указанного автобуса.</returns>
        Task<ITrip[]> GetBusTrips(DateTime fromDate, DateTime toDate, int busId);
    }
}