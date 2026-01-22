using System;
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
        /// Indicates whether the user agrees to the delivery of personalized ads. If not passed, it is assumed to be agreed
        /// </summary>
        /// <param name="paConsentType"></param>
        // ReSharper disable once InconsistentNaming
        public void SetPAConsentOverride(PanglePAConsentType paConsentType);
        
        /// <summary>
        /// Use to manually set the do not sell flag on the Pangle SDK.
        /// This is generally unnecessary as the Mediation SDK will set the consent flags automatically based on the latest consent info.
        /// </summary>
        [Obsolete("This method is no longer supported and will be removed in a future release. Use SetPAConsentOverride instead.")]
        public void SetDoNotSellOverride(PangleDoNotSellType doNotSellType);
    }
}
