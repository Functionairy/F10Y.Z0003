using System;

using F10Y.T0003;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IInstanceSetFlowDescriptorSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IInstanceSetFlowDescriptors _InstanceSetFlowDescriptors => InstanceSetFlowDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public IInstanceSetFlowDescriptor[] Publicize_AndContribute_ToF10Y => new IInstanceSetFlowDescriptor[]
        {
            _InstanceSetFlowDescriptors.Publicize,
            _InstanceSetFlowDescriptors.Contribute_ToF10Y
        };
    }
}
