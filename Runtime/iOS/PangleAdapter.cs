using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.Pangle.Common;
using UnityEngine;

namespace Chartboost.Mediation.Pangle.IOS
{
    internal sealed class PangleAdapter : IPangleAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            Pangle.PangleAdapter.Instance = new PangleAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMPangleAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMPangleAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMPangleAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMPangleAdapterPartnerDisplayName();
        
        /// <inheritdoc/>
        public void SetGDPRConsentOverride(PangleGDPRConsentType gdprConsent)
            => _CBMPangleAdapterSetGDPRConsentOverride((int)gdprConsent);

        /// <inheritdoc/>
        public void SetDoNotSellOverride(PangleDoNotSellType doNotSellType)
            => _CBMPangleAdapterSetDoNotSellOverride((int)doNotSellType);

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMPangleAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMPangleAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMPangleAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMPangleAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMPangleAdapterSetGDPRConsentOverride(int gdprConsent);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMPangleAdapterSetDoNotSellOverride(int doNotSellType);
    }
}
