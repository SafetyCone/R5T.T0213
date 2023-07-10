using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0213
{
    /// <inheritdoc cref="IAssemblyName"/>
    [StrongTypeImplementationMarker]
    public class AssemblyName : TypedBase<string>, IStrongTypeMarker,
        IAssemblyName
    {
        public AssemblyName(string value)
            : base(value)
        {
        }
    }
}