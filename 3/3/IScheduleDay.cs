using System;

namespace _3
{
    /// <summary>
    /// Интерфейс расписания на день.
    /// </summary>
    public interface IScheduleDay
    {
        /// <summary>
        /// День, к которому относится расписание.
        /// </summary>
        DateTime Day { get; }

        /// <summary>
        /// Назначенные рейсы на день.
        /// </summary>
        ITrip[] Trips { get; }
    }
}