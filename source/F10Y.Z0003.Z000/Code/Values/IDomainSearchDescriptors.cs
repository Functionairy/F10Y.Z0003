using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IDomainSearchDescriptors :
        Z0005.Z002.IDomainSearchDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z0005.Z002.IDomainSearchDescriptors _Z0005_Z002 => Z0005.Z002.DomainSearchDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z0005.IDomains.InstanceSet_Machinery"/>
        public DomainSearchDescriptor Find_InstanceSetMachinery => Instances.DomainSearchDescriptorOperator.From(
            Instances.Domains.InstanceSet_Machinery);
    }
}
