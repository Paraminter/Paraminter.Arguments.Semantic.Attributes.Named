namespace Paraminter.Arguments.Semantic.Attributes.Named.Models;

using Microsoft.CodeAnalysis;

using Paraminter.Associators.Models;

/// <summary>Represents semantic data about a named attribute argument.</summary>
public interface ISemanticAttributeNamedArgumentData
    : IArgumentData
{
    /// <summary>The named attribute argument.</summary>
    public abstract TypedConstant Argument { get; }
}
