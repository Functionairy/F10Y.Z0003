using System;

using F10Y.T0003;

using IOpinions_F10Y_Z0005 = F10Y.Z0005.IOpinions;


namespace F10Y.Z0003.Z000
{
    [ValuesMarker]
    public partial interface IOpinionDescriptors
    {
        public OpinionDescriptor Organizational_Functionary => new()
        {
            Opinion = Instances.Opinions.Organizational_Functionairy
        };

        /// <inheritdoc cref="IOpinions_F10Y_Z0005.Unopinionated"/>
        public OpinionDescriptor Unopinionated => Instances.OpinionDescriptorOperator.From(Instances.Opinions.Unopinionated);
    }
}
