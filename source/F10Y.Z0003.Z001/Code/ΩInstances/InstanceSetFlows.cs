using System;


namespace F10Y.Z0003.Z001
{
    public class InstanceSetFlows : IInstanceSetFlows
    {
        #region Infrastructure

        public static IInstanceSetFlows Instance { get; } = new InstanceSetFlows();


        private InstanceSetFlows()
        {
        }

        #endregion
    }
}
