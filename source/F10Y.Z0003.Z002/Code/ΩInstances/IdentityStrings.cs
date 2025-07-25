using System;


namespace F10Y.Z0003.Z002
{
    public class IdentityStrings : IIdentityStrings
    {
        #region Infrastructure

        public static IIdentityStrings Instance { get; } = new IdentityStrings();


        private IdentityStrings()
        {
        }

        #endregion
    }
}
