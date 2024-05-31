using System;

using R5T.T0131;


namespace R5T.Z0070
{
    /// <summary>
    /// File paths
    /// (of all, any, or undetermined opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker,
        Z004.IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles
        public Z002.IFilePaths _Strings => Z002.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
