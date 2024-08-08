using Chartboost.Logging;
using Chartboost.Mediation.Pangle.Common;

namespace Chartboost.Mediation.Pangle.Default
{
    internal class PangleDefault : IPangleAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => PangleAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => PangleAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "pangle";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "Pangle";

        /// <inheritdoc/>
        public void SetGDPRConsentOverride(PangleGDPRConsentType gdprConsent)
            => LogController.Log($"{nameof(SetGDPRConsentOverride)} does nothing on {nameof(PangleDefault)}", LogLevel.Info);

        /// <inheritdoc/>
        public void SetDoNotSellOverride(PangleDoNotSellType doNotSellType)
            => LogController.Log($"{nameof(SetDoNotSellOverride)} does nothing on {nameof(PangleDefault)}", LogLevel.Info);
    }
}
