# Chartboost Mediation Unity SDK - Pangle Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.pangle/Editor/PangleAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.pangle)

In order to add the Chartboost Mediation Unity SDK - Pangle Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.pangle": "5.0.3",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.Pangle)

To add the Chartboost Mediation Unity SDK - Pangle Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.Pangle` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.Pangle` package. Choose the appropriate version and install.

# AndroidManifest.xml Permissions

Add the required permissions to your app's `AndroidManifest.xml` file, as shown below.

```xml
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
```

# Usage
The following code block exemplifies usage of the `PangleAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {PangleAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.6.0.0.8.0
Debug.Log($"Adapter Native Version: {PangleAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 6.0.0.8
Debug.Log($"Partner SDK Version: {PangleAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: pangle
Debug.Log($"Partner Identifier: {PangleAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: Pangle
Debug.Log($"Partner Display Name: {PangleAdapter.PartnerDisplayName}");
```

## Set GDPR Consent Override

Use to manually set the consent status on the Pangle SDK. This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.

```csharp
// Consent
PangleAdapter.SetGDPRConsentOverride(PangleGDPRConsentType.PangleGDPRConsentConsent);

// No Consent
PangleAdapter.SetGDPRConsentOverride(PangleGDPRConsentType.PangleGDPRConsentNoConsent);

// Default
PangleAdapter.SetGDPRConsentOverride(PangleGDPRConsentType.PangleGDPRConsentTypeDefault);
```

## Set Do Not Sell Override
Use to manually set the do not sell flag on the Pangle SDK. This is generally unnecessary as the Mediation SDK will set the consent flags automatically based on the latest consent info.

```csharp
// Sell
PangleAdapter.SetDoNotSellOverride(PangleDoNotSellType.PangleGDoNotSellTypeSell);


// Not Sell
PangleAdapter.SetDoNotSellOverride(PangleDoNotSellType.PangleDoNotSellTypeNotSell);

// Default
PangleAdapter.SetDoNotSellOverride(PangleDoNotSellType.PangleDoNotSellTypeDefault);
```