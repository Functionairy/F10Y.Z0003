using System;

using F10Y.T0003;


namespace F10Y.Z0003.Z000
{
    /// <summary>
    /// Descriptors for F10Y-organization instance sets.
    /// </summary>
    [ValuesMarker]
    public partial interface IDescriptors
    {
        public Descriptor For_F10Y_L0000 => new()
        {
            Name = Instances.InstanceSet_Names.F10Y_L0000,
            Description = Instances.InstanceSet_Descriptions.For_F10Y_L0000,
            Identity = Instances.InstanceSet_Identities.For_F10Y_L0000,
        };

        public Descriptor For_F10Y_L0001 => new()
        {
            Name = "F10Y.L0001",
            Description = ".NET Standard 2.1 foundation library, Functionairy opinioned.",
            Identity = Instances.GuidOperator.From("AE40D924-76D4-4BA9-BFD5-CDE9BA506A79"),
        };

        public Descriptor For_F10Y_L0001_L001 => new()
        {
            Name = "F10Y.L0001.L001",
            Description = "Files convention library. (.NET Standard 2.1, Functionairy opinioned)",
            Identity = Instances.GuidOperator.From("814702CA-6119-48B7-86BA-3E031F65C92E"),
        };

        public Descriptor For_F10Y_L0006_Z000 => new()
        {
            Name = "F10Y.L0006.Z000",
            Description = ".NET Project file values library.",
            Identity = Instances.GuidOperator.From("3CF8418F-D852-48C5-8749-95F0F3CB4DBB"),
        };

        public Descriptor For_F10Y_L0060 => new()
        {
            Name = "F10Y.L0060",
            Description = ".NET 6.0 foundation library.",
            Identity = Instances.GuidOperator.From("40203D8B-A26A-45C3-8565-E0596F5B5836"),
        };

        public Descriptor For_F10Y_L0080 => new()
        {
            Name = "F10Y.L0080",
            Description = ".NET 8.0 foundation library.",
            Identity = Instances.GuidOperator.From("712B7497-A7C7-48C9-B561-C90BBFCAE429"),
        };

        public Descriptor For_F10Y_Z0011_Z001 => new()
        {
            Name = "F10Y.Z0011.Z001",
            Description = "Path and path-part values.",
            Identity = Instances.GuidOperator.From("D76104DD-E0B8-4456-A310-A5CA037A96D2"),
        };
    }
}
