using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    /// <summary>
    /// Functionairy and general domain descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IDomainDescriptors :
        Z0005.IDomainDescriptors,
        Z0006.IDomainDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="Z0005.IDomainDescriptors"/>
        [Ignore]
        public Z0005.IDomainDescriptors _Z0005 => Z0005.DomainDescriptors.Instance;

        /// <inheritdoc cref="Z0006.IDomainDescriptors"/>
        [Ignore]
        public Z0006.IDomainDescriptors _Z0006 => Z0006.DomainDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
