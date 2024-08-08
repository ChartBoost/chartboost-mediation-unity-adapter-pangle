using Chartboost.Constants;
using Chartboost.Mediation.Pangle.Common;
using UnityEngine;

namespace Chartboost.Mediation.Pangle.Android
{
    internal partial class PangleAdapter : IPangleAdapter
    {
        private const string PangleAdapterConfiguration = "com.chartboost.mediation.pangleadapter.PangleAdapterConfiguration";
        private const string FunctionSetGdprConsentOverride = "setGdprConsentOverride";
        private const string FunctionSetDoNotSellOverride = "setDoNotSellOverride";
        
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
        public void SetDoNotSellOverride(PangleDoNotSellType doNotSellType)
        {
            using var adapterConfiguration = new AndroidJavaObject(PangleAdapterConfiguration);
            adapterConfiguration.Call(FunctionSetDoNotSellOverride, (int)doNotSellType);
        }
    }
}
