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

        /// <summary>
        /// Проверка на положительное значение для целочисленного типа.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0) throw new ArgumentException($"{propertyName} должен быть положительным.");
        }

        /// <summary>
        /// Проверка на положительное значение для вещественного типа.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0) throw new ArgumentException($"{propertyName} должен быть положительным.");
        }

        /// <summary>
        /// Проверка значения на принадлежность заданному диапазону для целочисленного типа.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение в диапазоне (включительно).</param>
        /// <param name="max">Максимальное значение в диапазоне (исключительно).</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение находится вне заданного диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value >= max) throw new ArgumentException($"{propertyName} должен быть больше {min}, но меньше {max}.");
        }

        /// <summary>
        /// Проверка значения на принадлежность заданному диапазону для вещественного типа.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение в диапазоне (включительно).</param>
        /// <param name="max">Максимальное значение в диапазоне (исключительно).</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение находится вне заданного диапазона.</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value >= max) throw new ArgumentException($"{propertyName} должен быть больше {min}, но меньше {max}.");
        }
    }
}
