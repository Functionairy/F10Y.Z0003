using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    [DomainDescriptor(Z0008.IDomainNames.Opinion_Names_Constant)]
    public partial interface IOpinions :
        Z0005.IOpinions,
        Z0006.IOpinions
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z0005.IOpinions _Z0005 => Z0005.Opinions.Instance;

        [Ignore]
        public Z0006.IOpinions _Z0006 => Z0006.Opinions.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
