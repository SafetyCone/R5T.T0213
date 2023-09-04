using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0213
{
    /// <summary>
    /// Strongly-types a string as an assembly name.
    /// No assumption is made about whether the value is the short assembly name ("R5T.T0213"),
    /// or the full assembly name ("R5T.T0213, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null").
    /// </summary>
    [StrongTypeMarker]
    public interface IAssemblyName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}