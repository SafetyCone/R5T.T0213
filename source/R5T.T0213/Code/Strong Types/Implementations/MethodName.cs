using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0213
{
    /// <inheritdoc cref="IMethodName"/>
    [StrongTypeImplementationMarker]
    public class MethodName : TypedBase<string>, IStrongTypeMarker,
        IMethodName
    {
        public MethodName(string value)
            : base(value)
        {
        }
    }
}