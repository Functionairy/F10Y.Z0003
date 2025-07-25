using System;


namespace F10Y.Z0003.Z002
{
    public class SetEqualityOperationDescriptors : ISetEqualityOperationDescriptors
    {
        #region Infrastructure

        public static ISetEqualityOperationDescriptors Instance { get; } = new SetEqualityOperationDescriptors();


        private SetEqualityOperationDescriptors()
        {
        }

        #endregion
    }
}
