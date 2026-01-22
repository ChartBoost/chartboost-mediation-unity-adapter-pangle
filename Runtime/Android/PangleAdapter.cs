using Chartboost.Constants;
using Chartboost.Mediation.Pangle.Common;
using UnityEngine;

namespace Chartboost.Mediation.Pangle.Android
{
    internal sealed class PangleAdapter : IPangleAdapter
    {
        private const string PangleAdapterConfiguration = "com.chartboost.mediation.pangleadapter.PangleAdapterConfiguration";
        private const string FunctionSetGdprConsentOverride = "setGdprConsentOverride";
        
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
            using var adapterConfiguration = new AndroidJavaObject(PangleAdapterConfiguration);
            adapterConfiguration.Call(FunctionSetGdprConsentOverride, (int)gdprConsent);
        }

        /// <inheritdoc/>
        public void SetPAConsentOverride(PanglePAConsentType paConsentType)
        {
            // TODO - Implement on Android when native adapter update is complete.
        }

        /// <inheritdoc/>
        public void SetDoNotSellOverride(PangleDoNotSellType doNotSellType)
        {
            // Do nothing on Android, deprecated.
        }
    }
}
