# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.4 *(2025-02-18)*
This version of the Pangle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-pangle:5.6.2.+`
  * iOS: `ChartboostMediationAdapterPangle: ~> 5.6.2.0`

### Version 5.0.3 *(2025-02-18)*
This version of the Pangle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-pangle:5.6.2.+`
  * iOS: `ChartboostMediationAdapterPangle: ~> 5.6.1.0`

### Version 5.0.2 *(2024-10-18)*
This version of the Pangle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-pangle:5.6.1.+`
  * iOS: `ChartboostMediationAdapterPangle: ~> 5.6.1.0`

### Version 5.0.1 *(2024-10-18)*
This version of the Pangle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-pangle:5.6.2.+`
  * iOS: `ChartboostMediationAdapterPangle: ~> 5.6.0.0.0`

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - Pangle Adapter.

#Added
- Support for the following `Pangle` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-pangle:5.6.1.+`
    * iOS: `ChartboostMediationAdapterPangle ~> 5.6.0.0.0`
    
- `PangleAdapter.cs` with Configuration Properties for `Pangle`.
- The following properties have been added in `PangleAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`

- The following methods have been added in `PangleAdapter.cs`
    * `void SetGDPRConsentOverride(PangleGDPRConsentType gdprConsent)`
    * `void SetDoNotSellOverride(PangleDoNotSellType doNotSellType)`