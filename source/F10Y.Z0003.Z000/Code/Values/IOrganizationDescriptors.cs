using System;

using F10Y.T0003;

using IOrganizationNames_Functionairy = F10Y.Z0009.IOrganizationNames;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IOrganizationDescriptors
    {
        /// <summary>
        /// <para><value><inheritdoc cref="IOrganizationNames_Functionairy.F10Y" path="descendant::value"/></value></para>
        /// </summary>
        public OrganizationDescriptor_Name F10Y => Instances.OrganizationDescriptorOperator.From(
            Instances.OrganizationNames.F10Y);

        public OrganizationDescriptor_Invalid Invalid => OrganizationDescriptor_Invalid.Instance;
    }
}
