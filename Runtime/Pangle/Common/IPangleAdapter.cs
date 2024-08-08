using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.Pangle.Common
{
    /// <summary>
    /// The Chartboost Mediation Pangle adapter.
    /// </summary>
    internal interface IPangleAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Use to manually set the consent status on the Pangle SDK.
        /// This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.
        /// </summary>
        public void SetGDPRConsentOverride(PangleGDPRConsentType gdprConsent);

        /// <summary>
        /// Use to manually set the do not sell flag on the Pangle SDK.
        /// This is generally unnecessary as the Mediation SDK will set the consent flags automatically based on the latest consent info.
        /// </summary>
        public void SetDoNotSellOverride(PangleDoNotSellType doNotSellType);
    }
}
