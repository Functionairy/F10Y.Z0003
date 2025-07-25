using System;


namespace F10Y.Z0003.Z000
{
    public class NetVersionDescriptors : INetVersionDescriptors
    {
        #region Infrastructure

        public static INetVersionDescriptors Instance { get; } = new NetVersionDescriptors();


        private NetVersionDescriptors()
        {
        }

        #endregion
    }
}
