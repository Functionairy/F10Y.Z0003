using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IDomainSets :
        Z0005.IDomainSets,
        Z0006.IDomainSets
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public new Raw.IDomainSets _Raw => Raw.DomainSets.Instance;


        [Ignore]
        public Z0005.IDomainSets _Z0005 => Z0005.DomainSets.Instance;

        [Ignore]
        public Z0006.IDomainSets _Z0006 => Z0006.DomainSets.Instance;

#pragma warning restore IDE1006 // Naming Styles



    }
}
