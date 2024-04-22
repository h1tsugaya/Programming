static class CustomMethods
{
    static public readonly Type[] TypeModel = new Type[6] { typeof(Color), typeof(EducationForms),
                                            typeof(Genre), typeof(SmartphoneManufacturers),
                                            typeof(Seasons), typeof(Weekday) };

    static public TextBox[] TextBoxClassesRectangles { get; set; }
    static public TextBox[] TextBoxRectangles { get; set; }
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
