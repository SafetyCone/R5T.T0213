using System;


namespace R5T.T0213.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToAssemblyName(string)"/>
        public static IAssemblyName ToAssemblyName(this string value)
        {
            return Instances.StringOperator_Extensions.ToAssemblyName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToMethodName(string)"/>
        public static IMethodName ToMethodName(this string value)
        {
            return Instances.StringOperator_Extensions.ToMethodName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToTypeName(string)"/>
        public static ITypeName ToTypeName(this string value)
        {
            return Instances.StringOperator_Extensions.ToTypeName(value);
        }
    }
}
