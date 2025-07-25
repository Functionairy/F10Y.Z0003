using System;

using F10Y.T0003;

using IApplicabilities_General = F10Y.Z0008.IApplicabilities;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IApplicabilityDescriptors
    {
        /// <inheritdoc cref="IApplicabilities_General.General"/>
        public ApplicabilityDescriptor General => Instances.ApplicabilityDescriptorOperator.From_Applicability(Instances.Applicabilities.General);
    }
}
