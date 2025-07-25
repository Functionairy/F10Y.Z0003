using System;


namespace F10Y.Z0003.Z000
{
    public class InstanceSetFlowDescriptorSets : IInstanceSetFlowDescriptorSets
    {
        #region Infrastructure

        public static IInstanceSetFlowDescriptorSets Instance { get; } = new InstanceSetFlowDescriptorSets();


        private InstanceSetFlowDescriptorSets()
        {
        }

        #endregion
    }
}
