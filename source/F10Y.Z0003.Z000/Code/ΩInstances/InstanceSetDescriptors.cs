using System;


namespace F10Y.Z0003.Z000
{
    public class InstanceSetDescriptors : IInstanceSetDescriptors
    {
        #region Infrastructure

        public static IInstanceSetDescriptors Instance { get; } = new InstanceSetDescriptors();


        private InstanceSetDescriptors()
        {
        }

        #endregion
    }
}
