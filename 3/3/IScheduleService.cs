using System;
using System.Threading.Tasks;

namespace _3
{
    /// <summary>
    /// Интерфейс сервиса для получения расписания.
    /// </summary>
    public interface IScheduleService
    {
        /// <summary>
        /// Получить расписание за указанный период. Возможно асинхронное выполнение, чтобы не подвешивать систему, так как может выполняться долго.
        /// </summary>
        /// <param name="fromDate">Начальный день расписания.</param>
        /// <param name="toDate">Конечный день расписания.</param>
        /// <returns>Расписание по дням.</returns>
        Task<IScheduleDay[]> GetSchedule(DateTime fromDate, DateTime toDate);

        /// <summary>
        /// Получить расписание за указанный период по указанным маршрутам.
        /// Возможно асинхронное выполнение, чтобы не подвешивать систему, так как может выполняться долго.
        /// </summary>
        /// <param name="fromDate">Начальный день расписания.</param>
        /// <param name="toDate">Конечный день расписания.</param>
        /// <param name="routes">Маршруты, по которым необходимо получить расписание.</param>
        /// <returns>Расписание по дням.</returns>
        Task<IScheduleDay[]> GetSchedule(DateTime fromDate, DateTime toDate, IRoute[] routes);
    }
}