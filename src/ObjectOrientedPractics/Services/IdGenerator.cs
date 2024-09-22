namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс для генерации уникальных идентификаторов.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Статический счетчик для генерации ID.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Генерирует следующий уникальный идентификатор.
        /// </summary>
        /// <returns>Уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            return ++_idCounter;
        }
    }

}
