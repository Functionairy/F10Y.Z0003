using System;


namespace F10Y.Z0003.Z000
{
    public class Domains : IDomains
    {
        #region Infrastructure

        public static IDomains Instance { get; } = new Domains();


        private Domains()
        {
        }

        #endregion
    }
}
