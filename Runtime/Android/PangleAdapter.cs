using Chartboost.Constants;
using Chartboost.Mediation.Pangle.Common;
using UnityEngine;

namespace Chartboost.Mediation.Pangle.Android
{
    internal sealed class PangleAdapter : IPangleAdapter
    {
        private const string PangleAdapterConfiguration = "com.chartboost.mediation.pangleadapter.PangleAdapterConfiguration";
        // ReSharper disable once InconsistentNaming
        private const string FunctionSetPAConsentOverride = "setPAConsentOverride";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            Pangle.PangleAdapter.Instance = new PangleAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(PangleAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(PangleAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(PangleAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(PangleAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }

        /// <inheritdoc/>
        public void SetGDPRConsentOverride(PangleGDPRConsentType gdprConsent)
        {
            // Do nothing on Android, deprecated.
        }

        /// <inheritdoc/>
        public void SetPAConsentOverride(PanglePAConsentType paConsentType)
        {
            using var adapterConfiguration = new AndroidJavaObject(PangleAdapterConfiguration);
            adapterConfiguration.Call(FunctionSetPAConsentOverride, (int)paConsentType);
        }

        /// <inheritdoc/>
        public void SetDoNotSellOverride(PangleDoNotSellType doNotSellType)
        {
            // Do nothing on Android, deprecated.
        }
    }
}
