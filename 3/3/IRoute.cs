namespace _3
{
    /// <summary>
    /// Интерфейс описывает маршрут.
    /// </summary>
    public interface IRoute
    {
        /// <summary>
        /// Станции маршрута в порядке следования.
        /// </summary>
        IStation[] Stations { get; }

        /// <summary>
        /// Разрешённые типы автобусов для данного маршрута.
        /// </summary>
        IBusType[] AllowedBusTypes { get; }
    }
}