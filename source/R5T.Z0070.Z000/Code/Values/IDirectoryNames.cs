using System;

using R5T.T0131;


namespace R5T.Z0070.Z000
{
    /// <summary>
    /// Absolutely-named, fundamental, stringly-typed directory names
    /// (of all, or undetermined, opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>_framework</value></para>
        /// </summary>
        public string _framework => "_framework";

        /// <summary>
        /// <para><value>.git</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IDirectoryNames._git. (Un-opinionated opinion)")]
        public string _git => ".git";

        /// <summary>
        /// <para><value>_Types</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames._Types. (Rivet-specific opinion)")]
        public string _Types => "_Types";

        /// <summary>
        /// <para><value>.vs</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IDirectoryNames._vs. (Un-opinionated opinion)")]
        public string _vs => ".vs";

        /// <summary>
        /// <para><value>css</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0071.Z000.IDirectoryNames.css. (Common opinion)")]
        public string css => "css";

        /// <summary>
        /// <para><value>source</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0071.Z000.IDirectoryNames.source. (Common opinion)")]
        public string source => "source";

        /// <summary>
        /// <para><value>wwwroot</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IDirectoryNames.wwwroot. (Un-opinionated opinion)")]
        public string wwwroot => "wwwroot";

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>Classes</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames.Classes. (Rivet-specific opinion)")]
        public string Classes => "Classes";

        /// <summary>
        /// <para><value>Code</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames.Code. (Rivet-specific opinion)")]
        public string Code => "Code";

        /// <summary>
        /// <para><value>Components</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IDirectoryNames.Components. (Un-opinionated opinion)")]
        public string Components => "Components";

        /// <summary>
        /// <para><value>Definitions</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames.Definitions. (Rivet-specific opinion)")]
        public string Definitions => "Definitions";

        /// <summary>
        /// <para><value>Forms</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames.Forms. (Rivet-specific opinion)")]
        public string Forms => "Forms";

        /// <summary>
        /// <para><value>Implementations</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames.Implementations. (Rivet-specific opinion)")]
        public string Implementations => "Implementations";

        /// <summary>
        /// <para><value>Interfaces</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames.Interfaces. (Rivet-specific opinion)")]
        public string Interfaces => "Interfaces";

        /// <summary>
        /// <para><value>Layouts</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames.Layouts. (Rivet-specific opinion)")]
        public string Layouts => "Layouts";

        /// <summary>
        /// <para><value>Pages</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IDirectoryNames.Pages. (Un-opinionated opinion)")]
        public string Pages => "Pages";

        /// <summary>
        /// <para><value>Properties</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IDirectoryNames.Properties. (Un-opinionated opinion)")]
        public string Properties => "Properties";

        /// <summary>
        /// <para><value>Services</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames.Services. (Rivet-specific opinion)")]
        public string Services => "Services";

        /// <summary>
        /// <para><value>Shared</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IDirectoryNames.Shared. (Un-opinionated opinion)")]
        public string Shared => "Shared";

        /// <summary>
        /// <para><value>Strong Types</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0073.Z000.IDirectoryNames.Strong_Types. (Rivet-specific opinion)")]
        public string Strong_Types => "Strong Types";
    }
}
