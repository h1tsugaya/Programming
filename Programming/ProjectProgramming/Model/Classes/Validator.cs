using System;
using System.Diagnostics;

/// <summary>
/// Предоставляет методы для проверки значений.
/// </summary>
static class Validator
{
    /// <summary>
    /// Проверяет, что значение положительное.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    public static void AssertOnPositiveValue(int value)
    {
        if (value < 0) throw new ArgumentException($"The {new StackTrace().GetFrame(1).GetMethod().Name} property cannot be negative.");
    }

    /// <summary>
    /// Проверяет, что значение положительное.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    public static void AssertOnPositiveValue(double value)
    {
        if (value < 0) throw new ArgumentException($"The {new StackTrace().GetFrame(1).GetMethod().Name} property cannot be negative.");
    }

    /// <summary>
    /// Проверяет, что значение находится в заданном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимальное значение диапазона.</param>
    /// <param name="max">Максимальное значение диапазона.</param>
    public static void AssertValueInRange(int value, int min, int max)
    {
        if (value < min || value >= max) throw new ArgumentException($"The value {new StackTrace().GetFrame(1).GetMethod().Name} is out of range.");
    }

    /// <summary>
    /// Проверяет, что значение находится в заданном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимальное значение диапазона.</param>
    /// <param name="max">Максимальное значение диапазона.</param>
    public static void AssertValueInRange(double value, double min, double max)
    {
        if (value < min || value >= max) throw new ArgumentException($"The value {new StackTrace().GetFrame(1).GetMethod().Name} is out of range.");
    }
}