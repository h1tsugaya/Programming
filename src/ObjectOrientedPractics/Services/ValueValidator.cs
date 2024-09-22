namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс для проверки значений строковых полей.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет строку на соответствие заданной максимальной длине.
        /// Если строка превышает указанную длину, выбрасывается исключение.
        /// </summary>
        /// <param name="value">Строковое значение для проверки.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        /// <param name="propertyName">Имя свойства, вызвавшего метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если длина строки больше maxLength.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (string.IsNullOrEmpty(value) || value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
            }
        }
    }
}
