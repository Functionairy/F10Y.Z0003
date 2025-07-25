using System;

using F10Y.T0003;


namespace F10Y.Z0003.Z000
{
    /// <summary>
    /// Functionairy instance set descriptors.
    /// </summary>
    /// <remarks>
    /// There are no general instance sets (since all instance sets are owned).
    /// However, there <em>can</em> be general instance set facets (see F10Y.Z0005).
    /// And Functionairy-specific instance set facets (see F10Y.Z0006).
    /// </remarks>
    [ValuesMarker]
    public partial interface IInstanceSetDescriptors
    {
        /// <summary>
        /// .NET Standard 2.1 foundation library. (Unopinionated, no custom data types.)
        /// </summary>
        public InstanceSetDescriptor F10Y_L0000 => new()
        {
            Descriptor = Instances.Descriptors.For_F10Y_L0000,

            InstanceSetTypeDescriptor = Instances.InstanceSetTypeDescriptors.Foundation_Library,

            DomainDescriptor = Instances.DomainDescriptors.CSharp_NET,
            InstanceVarietyDescriptor = Instances.InstanceVarietyDescriptors.Functions_Values, /* Maybe also utility types? */

            OrganizationDescriptor = Instances.OrganizationDescriptors.F10Y,
            VisibilityDescriptor = Instances.VisibilityDescriptors.Public,

            NetVersionDescriptor = Instances.NetVersionDescriptors.netstandard2_1,
            DependencySetDescriptor = Instances.DependencySetDescriptors.None, /* TODO */

            ApplicabilityDescriptor = Instances.ApplicabilityDescriptors.General,
            OpinionDescriptor = Instances.OpinionDescriptors.Unopinionated,
        };

        /// <summary>
        /// .NET Standard 2.1 foundation library, Functionairy-opinioned. (No custom data types.)
        /// </summary>
        public InstanceSetDescriptor F10Y_L0001 => new()
        {
            Descriptor = Instances.Descriptors.For_F10Y_L0001,

            InstanceSetTypeDescriptor = Instances.InstanceSetTypeDescriptors.Foundation_Library,

            DomainDescriptor = Instances.DomainDescriptors.CSharp_NET,
            InstanceVarietyDescriptor = Instances.InstanceVarietyDescriptors.Functions_Values, /* Maybe also utility types? */

            OrganizationDescriptor = Instances.OrganizationDescriptors.F10Y,
            VisibilityDescriptor = Instances.VisibilityDescriptors.Public,

            NetVersionDescriptor = Instances.NetVersionDescriptors.netstandard2_1,
            DependencySetDescriptor = Instances.DependencySetDescriptors.None, /* TODO */

            ApplicabilityDescriptor = Instances.ApplicabilityDescriptors.General,
            OpinionDescriptor = Instances.OpinionDescriptors.Organizational_Functionary,
        };

        /// <summary>
        /// Files convention. (Functionairy-opinioned, .NET Standard 2.1)
        /// </summary>
        public InstanceSetDescriptor F10Y_L0001_L001 => new()
        {
            Descriptor = Instances.Descriptors.For_F10Y_L0001_L001,

            //InstanceSetTypeDescriptor = // None, for now. Just a library.

            DomainDescriptor = Instances.DomainDescriptors.FilesConvention,
            InstanceVarietyDescriptor = Instances.InstanceVarietyDescriptors.Functions_Values,

            OrganizationDescriptor = Instances.OrganizationDescriptors.F10Y,
            VisibilityDescriptor = Instances.VisibilityDescriptors.Public,

            NetVersionDescriptor = Instances.NetVersionDescriptors.netstandard2_1,
            DependencySetDescriptor = Instances.DependencySetDescriptors.None, /* TODO */

            ApplicabilityDescriptor = Instances.ApplicabilityDescriptors.General,
            OpinionDescriptor = Instances.OpinionDescriptors.Organizational_Functionary,
        };

        /// <summary>
        /// .NET Project file XML node (element and attribute) name values library.
        /// </summary>
        public InstanceSetDescriptor F10Y_L0006_Z000 => new()
        {
            Descriptor = Instances.Descriptors.For_F10Y_L0006_Z000,

            //InstanceSetTypeDescriptor = Instances.InstanceSetTypeDescriptors.Untyped,

            DomainDescriptor = Instances.DomainDescriptors.ProjectFile_XmlNodeNames,
            InstanceVarietyDescriptor = Instances.InstanceVarietyDescriptors.Values_Unadorned_Absolute_Direct,

            OrganizationDescriptor = Instances.OrganizationDescriptors.F10Y,
            VisibilityDescriptor = Instances.VisibilityDescriptors.Public,

            NetVersionDescriptor = Instances.NetVersionDescriptors.netstandard2_1,
            DependencySetDescriptor = Instances.DependencySetDescriptors.Markers_Only,

            ApplicabilityDescriptor = Instances.ApplicabilityDescriptors.General,
            OpinionDescriptor = Instances.OpinionDescriptors.Unopinionated,
        };

        /// <summary>
        /// .NET 6.0 foundation library. (Unopinionated)
        /// </summary>
        public InstanceSetDescriptor F10Y_L0060 => new()
        {
            Descriptor = Instances.Descriptors.For_F10Y_L0060,

            InstanceSetTypeDescriptor = Instances.InstanceSetTypeDescriptors.Foundation_Library,

            DomainDescriptor = Instances.DomainDescriptors.CSharp_NET,
            InstanceVarietyDescriptor = Instances.InstanceVarietyDescriptors.Functions_Values, /* Maybe also utility types? */

            OrganizationDescriptor = Instances.OrganizationDescriptors.F10Y,
            VisibilityDescriptor = Instances.VisibilityDescriptors.Public,

            NetVersionDescriptor = Instances.NetVersionDescriptors.net6,
            DependencySetDescriptor = Instances.DependencySetDescriptors.None, /* TODO */

            ApplicabilityDescriptor = Instances.ApplicabilityDescriptors.General,
            OpinionDescriptor = Instances.OpinionDescriptors.Unopinionated,
        };

        /// <summary>
        /// .NET 8.0 foundation library. (Unopinionated)
        /// </summary>
        public InstanceSetDescriptor F10Y_L0080 => new()
        {
            Descriptor = Instances.Descriptors.For_F10Y_L0080,

            InstanceSetTypeDescriptor = Instances.InstanceSetTypeDescriptors.Foundation_Library,

            DomainDescriptor = Instances.DomainDescriptors.CSharp_NET,
            InstanceVarietyDescriptor = Instances.InstanceVarietyDescriptors.Functions_Values, /* Maybe also utility types? */

            OrganizationDescriptor = Instances.OrganizationDescriptors.F10Y,
            VisibilityDescriptor = Instances.VisibilityDescriptors.Public,

            NetVersionDescriptor = Instances.NetVersionDescriptors.net8,
            DependencySetDescriptor = Instances.DependencySetDescriptors.None, /* TODO */

            ApplicabilityDescriptor = Instances.ApplicabilityDescriptors.General,
            OpinionDescriptor = Instances.OpinionDescriptors.Unopinionated,
        };

        /// <summary>
        /// Path and path-part values.
        /// </summary>
        public InstanceSetDescriptor F10Y_Z0011_Z001 => new()
        {
            Descriptor = Instances.Descriptors.For_F10Y_Z0011_Z001,

            //InstanceSetTypeDescriptor = , // TODO: unlabeled.

            DomainDescriptor = Instances.DomainDescriptors.Example_PathsAndPathParts,
            InstanceVarietyDescriptor = Instances.InstanceVarietyDescriptors.Values_Unadorned_Absolute_Direct,

            OrganizationDescriptor = Instances.OrganizationDescriptors.F10Y,
            VisibilityDescriptor = Instances.VisibilityDescriptors.Public,

            NetVersionDescriptor = Instances.NetVersionDescriptors.netstandard2_1,
            DependencySetDescriptor = Instances.DependencySetDescriptors.ValuesAndSurveyMarkerTypes_AndNetStandardDocumentationsSet,

            ApplicabilityDescriptor = Instances.ApplicabilityDescriptors.General,
            OpinionDescriptor = Instances.OpinionDescriptors.Unopinionated,
        };
    }
}
