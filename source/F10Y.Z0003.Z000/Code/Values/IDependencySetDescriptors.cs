using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    /// <summary>
    /// Funtionairy-specific and general dependency set descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IDependencySetDescriptors :
        Z0005.Z001.IDependencySetDescriptors,
        Z0006.Z001.IDependencySetDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="Z0005.Z001.IDependencySetDescriptors"/>
        [Ignore]
        public Z0005.Z001.IDependencySetDescriptors _Z0005_Z001 => Z0005.Z001.DependencySetDescriptors.Instance;

        /// <inheritdoc cref="Z0006.Z001.IDependencySetDescriptors"/>
        [Ignore]
        public Z0006.Z001.IDependencySetDescriptors _Z0006_Z001 => Z0006.Z001.DependencySetDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
