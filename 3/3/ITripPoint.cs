using System;

namespace _3
{
    /// <summary>
    /// Интерфейс описывает остановку рейса.
    /// </summary>
    public interface ITripPoint
    {
        /// <summary>
        /// Остановка.
        /// </summary>
        IStation Station { get; }

        /// <summary>
        /// Дата и время прибытия на остановку.
        /// </summary>
        DateTime ArrivalDateTime { get; }

        /// <summary>
        /// Время стоянки. Если стоянка по факту посадки пассажиров, то 0.
        /// </summary>
        TimeSpan StayTime { get; }
    }
}