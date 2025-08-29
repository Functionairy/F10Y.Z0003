using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    /// <summary>
    /// Instance set functionality domains.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// <para>
    /// If you want domains in the library containing instance set descriptor facets as values, see <see cref="Z0005.IDomains"/>.
    /// </para>
    /// <para>
    /// If you want the actual domain values themselves (values of instance set descriptor facete values), see <see cref="Z0008.IDomains"/>.
    /// </para>
    /// </remarks>
    [ValuesMarker]
    public partial interface IDomains :
        Z0005.IDomains,
        Z0006.IDomains
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z0005.IDomains _Z0005 => Z0005.Domains.Instance;

        [Ignore]
        public Z0006.IDomains _Z0006 => Z0006.Domains.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
