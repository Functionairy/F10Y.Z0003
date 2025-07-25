using System;


namespace F10Y.Z0003.Z000
{
    public class InstanceSet_Descriptions : IInstanceSet_Descriptions
    {
        #region Infrastructure

        public static IInstanceSet_Descriptions Instance { get; } = new InstanceSet_Descriptions();


        private InstanceSet_Descriptions()
        {
        }

        #endregion
    }
}
