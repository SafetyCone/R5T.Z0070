using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0070.Z002
{
    /// <summary>
    /// Conceptually named, derived, string-typed file paths
    /// (of all, any, or undetermined opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z000.IFilePaths _Raw => Z000.FilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// The output text file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output_txt" path="descendant::value"/></para>
        /// Placed in the temp directory.
        /// </summary>
        [Obsolete("See R5T.Z0071.Z002.IFilePaths.Output_Text_FilePath")]
        public string Output_Text_FilePath => _Raw.C_Temp_Output_txt;
    }
}
