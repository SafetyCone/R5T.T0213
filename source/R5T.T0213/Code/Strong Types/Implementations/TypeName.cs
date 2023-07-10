using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0213
{
    /// <inheritdoc cref="ITypeName"/>
    [StrongTypeImplementationMarker]
    public class TypeName : TypedBase<string>, IStrongTypeMarker,
        ITypeName
    {
        public TypeName(string value)
            : base(value)
        {
        }
    }
}