using Chartboost.Mediation.Pangle;
using Chartboost.Mediation.Pangle.Common;
using Chartboost.Testing;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class PangleAdapterTests
    {
        private const string Default = "PangleDefault";

        [Test]
        public void Identity() => AdapterContract.AssertIdentity("pangle", "Pangle", PangleAdapter.AdapterUnityVersion,
            PangleAdapter.PartnerIdentifier, PangleAdapter.PartnerDisplayName, PangleAdapter.AdapterNativeVersion, PangleAdapter.PartnerSDKVersion);

        [TestCase(PanglePAConsentType.PanglePAConsentTypeConsent)]
        [TestCase(PanglePAConsentType.PanglePAConsentTypeNoConsent)]
        public void SetPAConsentOverrideLogsOnTheDefault(PanglePAConsentType consent)
            => AdapterContract.AssertDefaultSetterLogs(nameof(PangleAdapter.SetPAConsentOverride), Default, () => PangleAdapter.SetPAConsentOverride(consent));

#pragma warning disable CS0618 // The obsolete setters still have to work until they're removed.
        [TestCase(PangleGDPRConsentType.PangleGDPRConsentConsent)]
        [TestCase(PangleGDPRConsentType.PangleGDPRConsentNoConsent)]
        [TestCase(PangleGDPRConsentType.PangleGDPRConsentTypeDefault)]
        public void SetGDPRConsentOverrideLogsOnTheDefault(PangleGDPRConsentType consent)
            => AdapterContract.AssertDefaultSetterLogs(nameof(PangleAdapter.SetGDPRConsentOverride), Default, () => PangleAdapter.SetGDPRConsentOverride(consent));

        [TestCase(PangleDoNotSellType.PangleGDoNotSellTypeSell)]
        [TestCase(PangleDoNotSellType.PangleDoNotSellTypeNotSell)]
        [TestCase(PangleDoNotSellType.PangleDoNotSellTypeDefault)]
        public void SetDoNotSellOverrideLogsOnTheDefault(PangleDoNotSellType doNotSell)
            => AdapterContract.AssertDefaultSetterLogs(nameof(PangleAdapter.SetDoNotSellOverride), Default, () => PangleAdapter.SetDoNotSellOverride(doNotSell));
#pragma warning restore CS0618
    }
}
