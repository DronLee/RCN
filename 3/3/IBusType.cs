namespace _3
{
    /// <summary>
    /// Интерфейс описывает признак автобуса (междугородний, двухсекционный и т.д.).
    /// </summary>
    public interface IBusType
    {
        /// <summary>
        /// Наименование признака.
        /// </summary>
        string Name { get; }
    }
}