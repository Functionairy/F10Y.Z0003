using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
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
