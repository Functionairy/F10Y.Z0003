using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    /// <summary>
    /// Instance set functionality domain names.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// <para>
    /// If you want domains in the library containing instance set descriptor facets as values, see <see cref="Z0005.IDomainNames"/>.
    /// </para>
    /// <para>
    /// If you want the actual domain values themselves (values of instance set descriptor facete values), see <see cref="Z0008.IDomainNames"/>.
    /// </para>
    /// </remarks>
    [ValuesMarker]
    [DomainDescriptor(Z0008.IDomainNames.Domain_Names_Constant)]
    public partial interface IDomainNames :
        Z0005.IDomainNames,
        Z0006.IDomainNames
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        Z0005.IDomainNames _Z0005 => Z0005.Domains.Instance;

        [Ignore]
        Z0006.IDomainNames _Z0006 => Z0006.DomainNames.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
