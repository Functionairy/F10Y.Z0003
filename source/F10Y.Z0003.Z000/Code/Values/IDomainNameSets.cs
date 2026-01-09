using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IDomainNameSets :
        Z0005.IDomainNameSets,
        Z0006.IDomainNameSets
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public new Raw.IDomainNameSets _Raw => Raw.DomainNameSets.Instance;


        [Ignore]
        public Z0005.IDomainNameSets _Z0005 => Z0005.DomainSets.Instance;

        [Ignore]
        public Z0006.IDomainNameSets _Z0006 => Z0006.DomainNameSets.Instance;

#pragma warning restore IDE1006 // Naming Styles



    }
}
