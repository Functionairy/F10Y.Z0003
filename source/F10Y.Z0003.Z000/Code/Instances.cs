using System;


namespace F10Y.Z0003.Z000
{
    public static class Instances
    {
        public static IApplicabilities Applicabilities => Z000.Applicabilities.Instance;
        public static L0026.T001.IApplicabilityDescriptorOperator ApplicabilityDescriptorOperator => L0026.T001.ApplicabilityDescriptorOperator.Instance;
        public static IApplicabilityDescriptors ApplicabilityDescriptors => Z000.ApplicabilityDescriptors.Instance;
        public static IDescriptors Descriptors => Z000.Descriptors.Instance;
        public static IDependencySetDescriptors DependencySetDescriptors => Z000.DependencySetDescriptors.Instance;
        public static L0026.T001.IDomainDescriptorOperator DomainDescriptorOperator => L0026.T001.DomainDescriptorOperator.Instance;
        public static IDomainDescriptors DomainDescriptors => Z000.DomainDescriptors.Instance;
        public static IDomains Domains => Z000.Domains.Instance;
        public static IDomainSets DomainSets => Z000.DomainSets.Instance;
        public static L0000.IGuidOperator GuidOperator => L0000.GuidOperator.Instance;
        public static L0026.T003.IInstanceSetFlowDescriptorOperator InstanceSetFlowDescriptorOperator => L0026.T003.InstanceSetFlowDescriptorOperator.Instance;
        public static IInstanceSetTypeDescriptors InstanceSetTypeDescriptors => Z000.InstanceSetTypeDescriptors.Instance;
        public static IInstanceSet_Descriptions InstanceSet_Descriptions => Z000.InstanceSet_Descriptions.Instance;
        public static IInstanceSet_Identities InstanceSet_Identities => Z000.InstanceSet_Identities.Instance;
        public static IInstanceSet_IdentityStrings InstanceSet_IdentityStrings => Z000.InstanceSet_IdentityStrings.Instance;
        public static IInstanceSet_Names InstanceSet_Names => Z000.InstanceSet_Names.Instance;
        public static L0026.T003.IInstanceVarietyDescriptorOperator InstanceVarietyDescriptorOperator => L0026.T003.InstanceVarietyDescriptorOperator.Instance;
        public static Z0005.Z001.IInstanceVarietyDescriptors InstanceVarietyDescriptors => Z0005.Z001.InstanceVarietyDescriptors.Instance;
        public static L0026.T001.INetVersionDescriptorOperator NetVersionDescriptorOperator => L0026.T001.NetVersionDescriptorOperator.Instance;
        public static INetVersionDescriptors NetVersionDescriptors => Z000.NetVersionDescriptors.Instance;
        public static L0026.T001.IOpinionDescriptorOperator OpinionDescriptorOperator => L0026.T001.OpinionDescriptorOperator.Instance;
        public static IOpinions Opinions => Z000.Opinions.Instance;
        public static IOpinionDescriptors OpinionDescriptors => Z000.OpinionDescriptors.Instance;
        public static L0026.T001.IOrganizationDescriptorOperator OrganizationDescriptorOperator => L0026.T001.OrganizationDescriptorOperator.Instance;
        public static IOrganizationDescriptors OrganizationDescriptors => Z000.OrganizationDescriptors.Instance;
        public static Z0009.IOrganizationNames OrganizationNames => Z0009.OrganizationNames.Instance;
        public static Z0002.ITargetFrameworkMonikers TargetFrameworkMonikers => Z0002.TargetFrameworkMonikers.Instance;
        public static L0026.T001.IVisibilityDescriptorOperator VisibilityDescriptorOperator => L0026.T001.VisibilityDescriptorOperator.Instance;
        public static Z0005.IVisibilityDescriptors VisibilityDescriptors => Z0005.VisibilityDescriptors.Instance;
    }
}