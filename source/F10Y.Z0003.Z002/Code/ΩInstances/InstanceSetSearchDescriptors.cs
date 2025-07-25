using System;


namespace F10Y.Z0003.Z002
{
    public class InstanceSetSearchDescriptors : IInstanceSetSearchDescriptors
    {
        #region Infrastructure

        public static IInstanceSetSearchDescriptors Instance { get; } = new InstanceSetSearchDescriptors();


        private InstanceSetSearchDescriptors()
        {
        }

        #endregion
    }
}
