public static class Validator
{
    /// <summary>
    /// Validates the product name.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <returns>True if valid, otherwise false.</returns>
    public static bool ValidateName(string name, out string errorMessage)
    {
        errorMessage = string.Empty;
        if (string.IsNullOrWhiteSpace(name))
        {
            errorMessage = "Название товара не должно быть пустым.";
            return false;
        }
        if (name.Length > 100)
        {
            errorMessage = "Название товара должно быть не длиннее 100 символов.";
            return false;
        }
        return true;
    }

    /// <summary>
    /// Validates the manufacturer name.
    /// </summary>
    /// <param name="manufacturer">The name of the manufacturer.</param>
    /// <returns>True if valid, otherwise false.</returns>
    public static bool ValidateManufacturer(string manufacturer, out string errorMessage)
    {
        errorMessage = string.Empty;
        if (string.IsNullOrWhiteSpace(manufacturer))
        {
            errorMessage = "Производитель не должен быть пустым.";
            return false;
        }
        if (manufacturer.Length > 100)
        {
            errorMessage = "Производитель должен быть не длиннее 100 символов.";
            return false;
        }
        return true;
    }
}
