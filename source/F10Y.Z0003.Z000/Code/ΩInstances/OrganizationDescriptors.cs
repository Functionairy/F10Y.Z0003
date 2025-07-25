using System;


namespace F10Y.Z0003.Z000
{
    public class OrganizationDescriptors : IOrganizationDescriptors
    {
        #region Infrastructure

        public static IOrganizationDescriptors Instance { get; } = new OrganizationDescriptors();


        private OrganizationDescriptors()
        {
        }

        #endregion
    }
}
