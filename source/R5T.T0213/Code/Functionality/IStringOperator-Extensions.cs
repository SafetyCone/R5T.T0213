using System;

using R5T.T0132;


namespace R5T.T0213.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IAssemblyName"/>
        public IAssemblyName ToAssemblyName(string value)
        {
            var output = new AssemblyName(value);
            return output;
        }

        /// <inheritdoc cref="IMethodName"/>
        public IMethodName ToMethodName(string value)
        {
            var output = new MethodName(value);
            return output;
        }

        /// <inheritdoc cref="ITypeName"/>
        public ITypeName ToTypeName(string value)
        {
            var output = new TypeName(value);
            return output;
        }
    }
}
