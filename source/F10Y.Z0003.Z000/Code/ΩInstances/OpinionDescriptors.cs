using System;


namespace F10Y.Z0003.Z000
{
    public class OpinionDescriptors : IOpinionDescriptors
    {
        #region Infrastructure

        public static IOpinionDescriptors Instance { get; } = new OpinionDescriptors();


        private OpinionDescriptors()
        {
        }

        #endregion
    }
}
