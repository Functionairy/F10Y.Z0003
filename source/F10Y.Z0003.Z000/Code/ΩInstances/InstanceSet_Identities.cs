using System;


namespace F10Y.Z0003.Z000
{
    public class InstanceSet_Identities : IInstanceSet_Identities
    {
        #region Infrastructure

        public static IInstanceSet_Identities Instance { get; } = new InstanceSet_Identities();


        private InstanceSet_Identities()
        {
        }

        #endregion
    }
}
