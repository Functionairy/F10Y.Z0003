using System;


namespace F10Y.Z0003.Z000
{
    public class InstanceSet_Names : IInstanceSet_Names
    {
        #region Infrastructure

        public static IInstanceSet_Names Instance { get; } = new InstanceSet_Names();


        private InstanceSet_Names()
        {
        }

        #endregion
    }
}
