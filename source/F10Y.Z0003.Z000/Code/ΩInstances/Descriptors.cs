using System;


namespace F10Y.Z0003.Z000
{
    public class Descriptors : IDescriptors
    {
        #region Infrastructure

        public static IDescriptors Instance { get; } = new Descriptors();


        private Descriptors()
        {
        }

        #endregion
    }
}
