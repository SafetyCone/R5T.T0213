using System;

using R5T.T0178;


namespace R5T.T0213
{
    /// <summary>
    /// Strongly-types a string as an assembly short name ("R5T.T0213").
    /// </summary>
    [StrongTypeMarker]
    public interface IShortAssemblyName : IStrongTypeMarker,
        IAssemblyName
    {
    }
}