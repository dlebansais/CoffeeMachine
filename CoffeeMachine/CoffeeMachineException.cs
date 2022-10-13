namespace CoffeeMachine;

using System;

/// <summary>
/// Represents an exception thrown by a <see cref="ICoffeeMachine"/>.
/// </summary>
public class CoffeeMachineException : InvalidOperationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CoffeeMachineException"/> class.
    /// </summary>
    /// <param name="message">The exception message.</param>
    public CoffeeMachineException(string message)
        : base(message)
    {
    }
}
