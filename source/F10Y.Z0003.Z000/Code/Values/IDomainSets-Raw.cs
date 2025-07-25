using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000.Raw
{
    [ValuesMarker]
    public partial interface IDomainSets :
        Z0005.Raw.IDomainSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static Z000.IDomains _Domains => Z000.Domains.Instance;


        [Ignore]
        public Z0005.Raw.IDomainSets _Z0005 => Z0005.Raw.DomainSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        
    }
}
