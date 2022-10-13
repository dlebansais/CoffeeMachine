namespace CoffeeMachine;

using System.Resources;

/// <summary>
/// Provides methods to read localized resources.
/// </summary>
public static class ResourceManagerHelper
{
    /// <summary>
    /// Reads a localized string in resources.
    /// </summary>
    /// <param name="id">The string identifier.</param>
    /// <param name="cultureInvariantString">The culture-invariant string to return if not found.</param>
    /// <returns>The localized string.</returns>
    public static string ReadString(string id, string cultureInvariantString)
    {
        return cultureInvariantString;
    }
}
