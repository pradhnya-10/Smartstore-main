﻿namespace Smartstore.Core.DataExchange.Export
{
    /// <summary>
    /// Declares data processing types supported by an export provider.
    /// Projection type controls whether to display corresponding projection fields while editing an export profile.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class ExportFeaturesAttribute : Attribute
    {
        public ExportFeatures Features { get; set; }
    }
}
