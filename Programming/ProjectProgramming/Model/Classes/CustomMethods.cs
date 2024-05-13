/// <summary>
/// Статический класс с пользовательскими методами.
/// </summary>
static class CustomMethods
{
    /// <summary>
    /// Массив типов моделей.
    /// </summary>
    static public readonly Type[] TypeModel = new Type[6] { typeof(Color), typeof(EducationForms),
                                            typeof(Genre), typeof(SmartphoneManufacturers),
                                            typeof(Seasons), typeof(Weekday) };

    /// <summary>
    /// Массив текстовых полей с прямоугольниками классов.
    /// </summary>
    static public TextBox[] TextBoxClassesRectangles { get; set; }

    /// <summary>
    /// Массив текстовых полей с прямоугольниками.
    /// </summary>
    static public TextBox[] TextBoxRectangles { get; set; }

    /// <summary>
    /// Попытка получить значение перечисления.
    /// </summary>
    /// <typeparam name="T">Тип перечисления.</typeparam>
    /// <param name="itemName">Имя элемента перечисления.</param>
    /// <param name="value">Возвращаемое значение.</param>
    /// <returns>True, если получилось получить значение, иначе - false.</returns>
    static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
    {
        if (Enum.TryParse<T>(itemName, true, out value))
        {
            return true;
        }
        value = default;
        return false;
    }
}
