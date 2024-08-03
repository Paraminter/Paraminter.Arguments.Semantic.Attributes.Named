namespace Paraminter.Arguments.Semantic.Type.Models;

using Microsoft.CodeAnalysis;

/// <summary>Represents semantic data about a named attribute argument.</summary>
public interface ISemanticAttributeNamedArgumentData
{
    /// <summary>The named attribute argument.</summary>
    public abstract TypedConstant Argument { get; }
}
