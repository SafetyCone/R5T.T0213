using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0213
{
    /// <inheritdoc cref="IShortAssemblyName"/>
    [StrongTypeImplementationMarker]
    public class ShortAssemblyName : TypedBase<string>, IStrongTypeMarker,
        IShortAssemblyName
    {
        public ShortAssemblyName(string value)
            : base(value)
        {
        }
    }
}