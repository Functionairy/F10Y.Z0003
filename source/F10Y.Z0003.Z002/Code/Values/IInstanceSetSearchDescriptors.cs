using System;

using F10Y.T0003;


namespace F10Y.Z0003.Z002
{
    [ValuesMarker]
    public partial interface IInstanceSetSearchDescriptors
    {
        #region Applicabilities

        InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor Find_Applicability_General => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Applicability_General),
                "Find general applicability instance sets.",
                "0BC76B46-571A-4A02-ABCD-2B54774AEF56")
            ,
            Value_IfMissingDescriptor = false,
            ApplicabilitySearchDescriptor = Instances.ApplicabilitySearchDescriptors.General
        };

        #endregion

        #region Domains

        InstanceSetSearchDescriptor_DomainSearchDescriptor Find_Domain_CSharp => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Domain_CSharp),
                "Find C# domain instance sets.",
                "1933202C-3660-4242-A471-1800529CA3FE")
            ,
            Value_IfMissingDescriptor = false,
            DomainSearchDescriptor = Instances.DomainSearchDescriptors.Find_CSharp
        };

        InstanceSetSearchDescriptor_DomainSearchDescriptor Find_Domain_DomainNames => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Domain_DomainNames),
                "Find domain name domain instance sets (yes, this is recursive).",
                "29D4101A-1FD1-4A24-B032-E8623E5A7906")
            ,
            Value_IfMissingDescriptor = false,
            DomainSearchDescriptor = Instances.DomainSearchDescriptors.Find_DomainNames
        };

        InstanceSetSearchDescriptor_DomainSearchDescriptor Find_Domain_Examples => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Domain_Examples),
                "Find instance sets with example domains.",
                "AC2B124D-D50D-4D05-A388-324B93D88F0C")
            ,
            Value_IfMissingDescriptor = false,
            DomainSearchDescriptor = Instances.DomainSearchDescriptors.Find_Examples
        };

        InstanceSetSearchDescriptor_DomainSearchDescriptor Find_Domain_PathAndPathParts => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Domain_PathAndPathParts),
                "Find instance sets with path and path-part domains.",
                "BEB54DC9-9A56-4CF3-92EF-0DA935821CD9")
            ,
            Value_IfMissingDescriptor = false,
            DomainSearchDescriptor = Instances.DomainSearchDescriptors.Find_PathAndPathParts
        };

        InstanceSetSearchDescriptor_DomainSearchDescriptor Find_Domain_ProjectXmlNodeNames_Subsets => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Domain_ProjectXmlNodeNames_Subsets),
                "Find instance sets with domain sets that are a *subset* of the .NET project XML node names domain set.",
                "A60C7348-432A-407B-B010-E778275DE709")
            ,
            Value_IfMissingDescriptor = false,
            DomainSearchDescriptor = Instances.DomainSearchDescriptors.Find_ProjectXmlNodeNames_Subsets
        };

        InstanceSetSearchDescriptor_DomainSearchDescriptor Find_Domain_ProjectXmlNodeNames_Supersets => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Domain_ProjectXmlNodeNames_Supersets),
                "Find instance sets with domain sets that are a *superset* of .NET project XML node names domain set.",
                "12CB304D-4D83-4DAA-BA1F-398257B08685")
            ,
            Value_IfMissingDescriptor = false,
            DomainSearchDescriptor = Instances.DomainSearchDescriptors.Find_ProjectXmlNodeNames_Supersets
        };

        #endregion

        #region Instance Set Types

        InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor Find_FoundationLibraries => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_FoundationLibraries),
                Instances.Descriptions.For_FindFoundationLibraries,
                Instances.IdentityStrings.For_FindFoundationLibraries),

            Value_IfMissingDescriptor = true,
            InstanceSetTypeSearchDescriptor = Instances.InstanceSetTypeSearchDescriptors.Find_FoundationLibraries
        };

        #endregion

        #region Instance Varieties

        InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor Find_Values => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Values),
                "Find values instance sets.",
                "A42220FA-7FA8-40BF-A0D0-8937543B6B85")
            ,
            Value_IfMissingDescriptor = false, // Must have the instance variety.
            InstanceVarietySearchDescriptor = Instances.InstanceVarietySearchDescriptors.Values
        };

        InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor Find_Values_AbsoluteDirectUnadorned => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Values_AbsoluteDirectUnadorned),
                "Find values instance sets containing absolutely-named, directly-implemented, unadorned-type values.",
                "CFA67398-B485-4DFD-A173-3B11FE53317C")
            ,
            Value_IfMissingDescriptor = false, // Must have the instance variety.
            InstanceVarietySearchDescriptor = Instances.InstanceVarietySearchDescriptors.Absolute_Direct_Unadorned
        };

        #endregion

        #region .NET Versions

        InstanceSetSearchDescriptor_NetVersionSearchDescriptor Find_NetVersion_netstandard2_1 => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
               nameof(Find_NetVersion_netstandard2_1),
               "Find .NET Standard 2.1 version instance sets.",
               "5862274F-35AA-4A58-8D3F-ED1DED638F56")
           ,
            Value_IfMissingDescriptor = false,
            NetVersionSearchDescriptor = Instances.NetVersionSearchDescriptors.Find_netstandard2_1
        };

        InstanceSetSearchDescriptor_NetVersionSearchDescriptor Find_NetVersion_net6 => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
               nameof(Find_NetVersion_netstandard2_1),
               "Find .NET 6.0 version instance sets.",
               "4A2066C1-5DC1-47A6-891B-D202D415DC62")
           ,
            Value_IfMissingDescriptor = false,
            NetVersionSearchDescriptor = Instances.NetVersionSearchDescriptors.Find_net6_0
        };

        InstanceSetSearchDescriptor_NetVersionSearchDescriptor Find_NetVersion_net8 => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
               nameof(Find_NetVersion_netstandard2_1),
               "Find .NET 8.0 version instance sets.",
               "C8284DD2-985F-4E05-82DB-66E68334A39E")
           ,
            Value_IfMissingDescriptor = false,
            NetVersionSearchDescriptor = Instances.NetVersionSearchDescriptors.Find_net8_0
        };

        #endregion

        #region Visibility

        InstanceSetSearchDescriptor_VisibilitySearchDescriptor Find_Private => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Private),
                "Find private instance sets.",
                "3DE6EC10-1799-4FA6-AE0E-3A3DC239CA48")
            ,
            Value_IfMissingDescriptor = true,
            VisibilitySearchDescriptor = Instances.VisibilitySearchDescriptors.Find_Private
        };

        InstanceSetSearchDescriptor_VisibilitySearchDescriptor Find_Public => new()
        {
            Descriptor = Instances.DescriptorOperator.From(
                nameof(Find_Public),
                "Find instance sets.",
                "3B4B3332-4A78-48C5-B7CE-0E2A786AC31A")
            ,
            Value_IfMissingDescriptor = true,
            VisibilitySearchDescriptor = Instances.VisibilitySearchDescriptors.Find_Public
        };

        #endregion
    }
}
