using System;


namespace F10Y.Z0003.Z000
{
    public class InstanceSetTypeDescriptors : IInstanceSetTypeDescriptors
    {
        #region Infrastructure

        public static IInstanceSetTypeDescriptors Instance { get; } = new InstanceSetTypeDescriptors();


        private InstanceSetTypeDescriptors()
        {
        }

        #endregion
    }
}
