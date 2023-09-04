using System;

using R5T.T0178;


namespace R5T.T0213
{
    /// <summary>
    /// Strongly-types a string as an assembly full name ("R5T.T0213, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null").
    /// </summary>
    [StrongTypeMarker]
    public interface IFullAssemblyName : IStrongTypeMarker,
        IAssemblyName
    {
    }
}