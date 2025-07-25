using System;


namespace F10Y.Z0003.Z000
{
    public class InstanceSet_IdentityStrings : IInstanceSet_IdentityStrings
    {
        #region Infrastructure

        public static IInstanceSet_IdentityStrings Instance { get; } = new InstanceSet_IdentityStrings();


        private InstanceSet_IdentityStrings()
        {
        }

        #endregion
    }
}
