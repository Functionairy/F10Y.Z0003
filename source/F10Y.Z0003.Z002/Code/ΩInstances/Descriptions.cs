using System;


namespace F10Y.Z0003.Z002
{
    public class Descriptions : IDescriptions
    {
        #region Infrastructure

        public static IDescriptions Instance { get; } = new Descriptions();


        private Descriptions()
        {
        }

        #endregion
    }
}
