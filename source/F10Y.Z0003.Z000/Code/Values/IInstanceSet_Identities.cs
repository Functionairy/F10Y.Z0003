using System;

using F10Y.T0003;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IInstanceSet_Identities
    {
#pragma warning disable IDE1006 // Naming Styles

        private static L0000.IGuidOperator _GuidOperator => Instances.GuidOperator;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IInstanceSet_IdentityStrings.For_F10Y_L0000"/>
        public Guid For_F10Y_L0000 => _GuidOperator.From(Instances.InstanceSet_IdentityStrings.For_F10Y_L0000);
    }
}
