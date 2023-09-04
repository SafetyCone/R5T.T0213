using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0213
{
    /// <inheritdoc cref="IFullAssemblyName"/>
    [StrongTypeImplementationMarker]
    public class FullAssemblyName : TypedBase<string>, IStrongTypeMarker,
        IFullAssemblyName
    {
        public FullAssemblyName(string value)
            : base(value)
        {
        }
    }
}