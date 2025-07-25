using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IInstanceSetTypeDescriptors :
        Z0005.IInstanceSetTypeDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z0005.IInstanceSetTypeDescriptors _Z0005 => Z0005.InstanceSetTypeDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
