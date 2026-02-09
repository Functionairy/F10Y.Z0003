using System;

using F10Y.T0003;


namespace F10Y.Z0003.Z002
{
    public partial interface IInstanceSetSearchDescriptors
    {
        /// <summary>
        /// Find equality operation descriptor script instance sets.
        /// <para>---</para>
        /// <inheritdoc cref="Find_Domain_SetEqualityOperationDescriptor" path="/summary"/>
        /// <para>---</para>
        /// <inheritdoc cref="Find_Scripts" path="/summary"/>
        /// </summary>
        InstanceSetSearchDescriptor_Aggregate Find_Domain_SetEqualityOperationDescriptor_Scripts => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Domain_SetEqualityOperationDescriptor_Scripts),
                "Find set equality operation descriptor scripts.",
                "8B491BF1-6FFF-448B-A162-A0A5BC77B27B"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_SetEqualityOperationDescriptor,
                this.Find_Scripts
            )
        );

        /// <summary>
        /// Find equality operation descriptor script instance sets.
        /// <para>---</para>
        /// <inheritdoc cref="Find_Domain_EqualityOperationDescriptor" path="/summary"/>
        /// <para>---</para>
        /// <inheritdoc cref="Find_Scripts" path="/summary"/>
        /// </summary>
        InstanceSetSearchDescriptor_Aggregate Find_Domain_EqualityOperationDescriptor_Scripts => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Domain_EqualityOperationDescriptor_Scripts),
                "Find equality operation descriptor scripts.",
                "123B6AFD-BB01-4E2A-90F9-DDD70E9E2188"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_EqualityOperationDescriptor,
                this.Find_Scripts
            )
        );

        InstanceSetSearchDescriptor_Aggregate Find_DomainName_Values => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_DomainName_Values),
                "Find domain name values.",
                "77279980-FA2A-4479-BC3F-2BA0B5DDFD7D"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_DomainNames,
                this.Find_Values
            )
        );

        InstanceSetSearchDescriptor_Aggregate Find_Example_PathAndPathPartValues => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Example_PathAndPathPartValues),
                "Find example path and path-part values.",
                "382C2106-CD4E-411D-A340-B4A66E911E12"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_Examples,
                this.Find_Domain_PathAndPathParts,
                this.Find_Values_AbsoluteDirectUnadorned
            )
        );

        InstanceSetSearchDescriptor_Aggregate Find_ProjectXmlNodeNames_Values => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_ProjectXmlNodeNames_Values),
                "Find project XML node name values (absolute, direct, unadorned).",
                "428E6A95-0E7B-4968-A0F9-6AB96380A118"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                //this.Find_Domain_ProjectXmlNodeNames_Subsets,
                this.Find_Domain_ProjectXmlNodeNames_Supersets, // We want to find domain supersets of the search domain set.
                this.Find_Values_AbsoluteDirectUnadorned
            )
        );

        InstanceSetSearchDescriptor_Aggregate Find_dotNETProjectXmlNodeNames_Values => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_dotNETProjectXmlNodeNames_Values),
                "Find project XML node name values.",
                "23B37E5C-124E-4DA1-806F-D0EAC8F3D65B"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_dotNETProjectXmlNodeNames,
                this.Find_Values
            )
        );

        InstanceSetSearchDescriptor_Aggregate Find_ProjectXmlNodeNames_Values_Public => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_ProjectXmlNodeNames_Values_Public),
                "Find public project XML node name values (absolute, direct, unadorned).",
                "D1CC7A41-3033-493B-9B77-3E83CDFE23C0"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_ProjectXmlNodeNames_Supersets,
                this.Find_Public,
                this.Find_Values_AbsoluteDirectUnadorned
            )
        );

        /// <summary>
        /// Find .NET project XML node name values instance sets.
        /// <para>---</para>
        /// <inheritdoc cref="Find_Domain_dotNETProjectXmlNodeNames" path="/summary"/>
        /// <para>---</para>
        /// <inheritdoc cref="Find_Values" path="/summary"/>
        /// </summary>
        InstanceSetSearchDescriptor_Aggregate Find_Domain_dotNETProjectXmlNodeName_Values => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Domain_dotNETProjectXmlNodeName_Values),
                "Find dotNET project XML node name values.",
                "6680DE6D-EE08-4F24-B623-0306B92A18B6"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_dotNETProjectXmlNodeNames,
                this.Find_Values
            )
        );

        /// <summary>
        /// Find .NET project XML element name values instance sets.
        /// <para>---</para>
        /// <inheritdoc cref="Find_Domain_dotNETProjectXmlElementNames" path="/summary"/>
        /// <para>---</para>
        /// <inheritdoc cref="Find_Values" path="/summary"/>
        /// </summary>
        InstanceSetSearchDescriptor_Aggregate Find_Domain_dotNETProjectXmlElementName_Values => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Domain_dotNETProjectXmlElementName_Values),
                "Find dotNET project XML element name values.",
                "F9214804-34D6-4445-B725-29EA9CA3C949"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_dotNETProjectXmlElementNames,
                this.Find_Values
            )
        );

        /// <summary>
        /// Find .NET project XML element name values instance sets.
        /// <para>---</para>
        /// <inheritdoc cref="Find_Domain_dotNETProjectXml_Names_Subsets" path="/summary"/>
        /// <para>---</para>
        /// <inheritdoc cref="Find_Values" path="/summary"/>
        /// </summary>
        InstanceSetSearchDescriptor_Aggregate Find_Domain_dotNETProjectXml_Name_Subsets_Values => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Domain_dotNETProjectXml_Name_Subsets_Values),
                "Find dotNET project XML name values.",
                "08FC2E23-1F18-4B4E-9EA9-A58D145D1A1A"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_dotNETProjectXml_Names_Subsets,
                this.Find_Values
            )
        );

        /// <summary>
        /// Find .NET project XML element name values instance sets.
        /// <para>---</para>
        /// <inheritdoc cref="Find_Domain_dotNETProjectXml_Names_Supersets" path="/summary"/>
        /// <para>---</para>
        /// <inheritdoc cref="Find_Values" path="/summary"/>
        /// </summary>
        InstanceSetSearchDescriptor_Aggregate Find_Domain_dotNETProjectXml_Name_Supersets_Values => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Domain_dotNETProjectXml_Name_Supersets_Values),
                "Find dotNET project XML name values.",
                "D9389A85-2EB5-4B5D-939D-834D3845D5F7"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_dotNETProjectXml_Names_Supersets,
                this.Find_Values
            )
        );

        /// <summary>
        /// Find .NET project XML element name values instance sets.
        /// <para>---</para>
        /// <inheritdoc cref="Find_Domain_dotNETProjectXmlNodeNamesTest_Subsets" path="/summary"/>
        /// <para>---</para>
        /// <inheritdoc cref="Find_Values" path="/summary"/>
        /// </summary>
        InstanceSetSearchDescriptor_Aggregate Find_Domain_dotNETProjectXmlNodeNamesTest_Subsets_Values => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Domain_dotNETProjectXmlNodeNamesTest_Subsets_Values),
                "Find dotNET project XML name values.",
                "814A5633-90C3-4F90-95C4-6C8FE1081DEB"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_dotNETProjectXmlNodeNamesTest_Subsets,
                this.Find_Values
            )
        );

        /// <summary>
        /// Find .NET project XML element name values instance sets.
        /// <para>---</para>
        /// <inheritdoc cref="Find_Domain_dotNETProjectXmlNodeNamesTest_Supersets" path="/summary"/>
        /// <para>---</para>
        /// <inheritdoc cref="Find_Values" path="/summary"/>
        /// </summary>
        InstanceSetSearchDescriptor_Aggregate Find_Domain_dotNETProjectXmlNodeNamesTest_Supersets_Values => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Domain_dotNETProjectXmlNodeNamesTest_Supersets_Values),
                "Find dotNET project XML name values.",
                "44F8E6A4-20C4-4FED-9349-79D538FCAC78"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_dotNETProjectXmlNodeNamesTest_Supersets,
                this.Find_Values
            )
        );

        /// <summary>
        /// Find .NET project XML function instance sets.
        /// <para>---</para>
        /// <inheritdoc cref="Find_Domain_dotNETProjectXml_Supersets" path="/summary"/>
        /// <para>---</para>
        /// <inheritdoc cref="Find_Functions" path="/summary"/>
        /// </summary>
        InstanceSetSearchDescriptor_Aggregate Find_Domain_dotNETProjectXml_Functions => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_Domain_dotNETProjectXml_Functions),
                "Find dotNET project XML functions.",
                "123B6AFD-BB01-4E2A-90F9-DDD70E9E2188"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_dotNETProjectXml_Supersets,
                this.Find_Functions
            )
        );
    }
}
