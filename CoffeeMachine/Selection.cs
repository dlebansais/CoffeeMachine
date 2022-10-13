namespace CoffeeMachine;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1611 // Element parameters should be documented

/// <summary>
/// Represents a selection in a list of choices.
/// </summary>
public record struct Selection(int Value)
{
    /// <summary>
    /// Converters Selection ←→ int.
    /// </summary>
    public static implicit operator int(Selection selection) => selection.Value;
    public static implicit operator Selection(int value) => new Selection(value);
}
