#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <PAGAdSDK/PAGSdk.h>
#import <ChartboostMediationAdapterPangle/ChartboostMediationAdapterPangle-Swift.h>

extern "C" {

    const char * _CBMPangleAdapterAdapterVersion(){
        return toCStringOrNull([PangleAdapterConfiguration adapterVersion]);
    }

    const char * _CBMPangleAdapterPartnerSDKVersion(){
        return toCStringOrNull([PangleAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMPangleAdapterPartnerId(){
        return toCStringOrNull([PangleAdapterConfiguration partnerID]);
    }

    const char * _CBMPangleAdapterPartnerDisplayName(){
        return toCStringOrNull([PangleAdapterConfiguration partnerDisplayName]);
    }

    void _CBMPangleAdapterSetGDPRConsentOverride(int gdprConsent)
    {
        [PangleAdapterConfiguration setGDPRConsentOverride:(PAGGDPRConsentType)gdprConsent];
    }

    void _CBMPangleAdapterSetDoNotSellOverride(int doNotSellType)
    {
        [PangleAdapterConfiguration setDoNotSellOverride:(PAGDoNotSellType)doNotSellType];
    }
}
