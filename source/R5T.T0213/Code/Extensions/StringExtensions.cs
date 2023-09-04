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

        /// <inheritdoc cref="IStringOperator.ToFullAssemblyName(string)"/>
        public static IFullAssemblyName ToFullAssemblyName(this string value)
        {
            return Instances.StringOperator_Extensions.ToFullAssemblyName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToShortAssemblyName(string)"/>
        public static IShortAssemblyName ToShortAssemblyName(this string value)
        {
            return Instances.StringOperator_Extensions.ToShortAssemblyName(value);
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
