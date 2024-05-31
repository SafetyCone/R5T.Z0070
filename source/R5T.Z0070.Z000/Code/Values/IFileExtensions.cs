using System;

using R5T.T0131;


namespace R5T.Z0070.Z000
{
    /// <summary>
    /// Absolutely-named, fundamental, stringly-typed file extensions
    /// (of all, or undetermined, opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>bin</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.bin")]
        public string bin => "bin";

        /// <summary>
        /// <para><value>bmp</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.bmp")]
        public string bmp => "bmp";

        /// <summary>
        /// <para><value>cs</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.cs")]
        public string cs => "cs";

        /// <summary>
        /// <para><value>csproj</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.csproj")]
        public string csproj => "csproj";

        /// <summary>
        /// <para><value>dat</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.dat")]
        public string dat => "dat";

        /// <summary>
        /// <para><value>dll</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.dll")]
        public string dll => "dll";

        /// <summary>
        /// <para><value>jpeg</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.jpeg")]
        public string jpeg => "jpeg";

        /// <summary>
        /// <para><value>jpg</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.jpg")]
        public string jpg => "jpg";

        /// <summary>
        /// <para><value>json</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.json")]
        public string json => "json";

        /// <summary>
        /// <para><value>png</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.png")]
        public string png => "png";

        /// <summary>
        /// <para><value>resx</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.resx")]
        public string resx => "resx";

        /// <summary>
		/// <para><value>sln</value></para>
		/// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.sln")]
        public string sln => "sln";

        /// <summary>
        /// <para><value>txt</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.txt")]
        public string txt => "txt";

        /// <summary>
        /// <para><value>tmp</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.tmp")]
        public string tmp => "tmp";

        /// <summary>
        /// <para><value>xml</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions.xml")]
        public string xml => "xml";

#pragma warning restore IDE1006 // Naming Styles
    }
}
