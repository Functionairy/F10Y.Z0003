using System;

using F10Y.T0003;


namespace F10Y.Z0003.Z000
{
    /// <summary>
    /// Joint generally-applicable and Functionairy-applicable applicability values.
    /// </summary>
    [ValuesMarker]
    [DomainDescriptor(Z0008.IDomainNames.Applicability_Names_Constant)]
    public partial interface IApplicabilities :
        Z0008.IApplicabilities,
        Z0006.IApplicabilities
    {
        
    }
}
