using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.Pangle.Common;
using Chartboost.Mediation.Pangle.Default;

namespace Chartboost.Mediation.Pangle
{
    /// <inheritdoc cref="IPangleAdapter"/>
    public static class PangleAdapter 
    {
        internal static IPangleAdapter Instance = new PangleDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.1";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IPangleAdapter.SetGDPRConsentOverride"/>
        public static void SetGDPRConsentOverride(PangleGDPRConsentType gdprConsent) 
            => Instance.SetGDPRConsentOverride(gdprConsent);

        /// <inheritdoc cref="IPangleAdapter.SetDoNotSellOverride"/>
        public static void SetDoNotSellOverride(PangleDoNotSellType doNotSellType) 
            => Instance.SetDoNotSellOverride(doNotSellType);
    }
}
