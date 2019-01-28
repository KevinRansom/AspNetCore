// <auto-generated />
namespace Microsoft.AspNetCore.Localization
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Localization.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Please provide at least one culture.
        /// </summary>
        internal static string Exception_CulturesShouldNotBeEmpty
        {
            get => GetString("Exception_CulturesShouldNotBeEmpty");
        }

        /// <summary>
        /// Please provide at least one culture.
        /// </summary>
        internal static string FormatException_CulturesShouldNotBeEmpty()
            => GetString("Exception_CulturesShouldNotBeEmpty");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
