using System;

using F10Y.T0003;


namespace F10Y.Z0003.Z002
{
    public partial interface IInstanceSetSearchDescriptors
    {
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

        InstanceSetSearchDescriptor_Aggregate Find_ProjectXmlNodeNames_Values_Public => Instances.InstanceSetSearchDescriptorOperator.From(
            Instances.DescriptorOperator.From(
                nameof(Find_ProjectXmlNodeNames_Values),
                "Find public project XML node name values (absolute, direct, unadorned).",
                "D1CC7A41-3033-493B-9B77-3E83CDFE23C0"),
            Instances.ArrayOperator.From<IInstanceSetSearchDescriptor>(
                this.Find_Domain_ProjectXmlNodeNames_Supersets,
                this.Find_Public,
                this.Find_Values_AbsoluteDirectUnadorned
            )
        );
    }
}
