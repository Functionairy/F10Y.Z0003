using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IInstanceSetFlowDescriptors :
        Z0005.IInstanceSetFlowDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IInstanceSetFlowDescriptorSets _InstanceSetFlowDescriptorSets => InstanceSetFlowDescriptorSets.Instance;

        [Ignore]
        public Z0005.IInstanceSetFlowDescriptors _Z0005 => Z0005.InstanceSetFlowDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public InstanceSetFlowDescriptor_Contribute Contribute_ToF10Y => Instances.InstanceSetFlowDescriptorOperator.Contribute(
            Instances.OrganizationNames.F10Y);

        public InstanceSetFlowDescriptor_Aggregate Publicize_AndContribute_ToF10Y_AsAggregate => Instances.InstanceSetFlowDescriptorOperator.From(
            _InstanceSetFlowDescriptorSets.Publicize_AndContribute_ToF10Y);

        public IInstanceSetFlowDescriptor Publicize_AndContribute_ToF10Y => this.Publicize_AndContribute_ToF10Y_AsAggregate;
    }
}
