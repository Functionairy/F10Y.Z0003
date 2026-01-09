using System;


namespace F10Y.Z0003.Z000
{
    public class DomainNameSets : IDomainNameSets
    {
        #region Infrastructure

        public static IDomainNameSets Instance { get; } = new DomainNameSets();


        private DomainNameSets()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0003.Z000.Raw
{
    public class DomainNameSets : IDomainNameSets
    {
        #region Infrastructure

        public static IDomainNameSets Instance { get; } = new DomainNameSets();


        private DomainNameSets()
        {
        }

        #endregion
    }
}
