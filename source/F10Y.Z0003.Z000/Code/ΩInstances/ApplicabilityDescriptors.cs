using System;


namespace F10Y.Z0003.Z000
{
    public class ApplicabilityDescriptors : IApplicabilityDescriptors
    {
        #region Infrastructure

        public static IApplicabilityDescriptors Instance { get; } = new ApplicabilityDescriptors();


        private ApplicabilityDescriptors()
        {
        }

        #endregion
    }
}
