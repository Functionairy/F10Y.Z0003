using System;


namespace F10Y.Z0003.Z000
{
    public class Applicabilities : IApplicabilities
    {
        #region Infrastructure

        public static IApplicabilities Instance { get; } = new Applicabilities();


        private Applicabilities()
        {
        }

        #endregion
    }
}
