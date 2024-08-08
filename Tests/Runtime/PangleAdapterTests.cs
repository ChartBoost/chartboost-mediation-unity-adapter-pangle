using Chartboost.Logging;
using Chartboost.Mediation.Pangle;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class PangleAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => PangleAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => PangleAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => PangleAdapter.PartnerIdentifier);

        
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => PangleAdapter.PartnerDisplayName);

        [Test, Order(0)]
        public void SetGDPRConsentConsent() 
            => PangleAdapter.SetGDPRConsentOverride(PangleGDPRConsentType.PangleGDPRConsentConsent);

        [Test, Order(1)]
        public void SetGDPRConsentNoConsent() 
            => PangleAdapter.SetGDPRConsentOverride(PangleGDPRConsentType.PangleGDPRConsentNoConsent);

        [Test, Order(2)]
        public void SetGDPRConsentDefault() 
            => PangleAdapter.SetGDPRConsentOverride(PangleGDPRConsentType.PangleGDPRConsentTypeDefault);

        [Test, Order(0)]
        public void SetDoNotSellTypeSell() 
            => PangleAdapter.SetDoNotSellOverride(PangleDoNotSellType.PangleGDoNotSellTypeSell);
        
        [Test, Order(1)]
        public void SetDoNotSellTypeNotSell() 
            => PangleAdapter.SetDoNotSellOverride(PangleDoNotSellType.PangleDoNotSellTypeNotSell);
        
        [Test, Order(2)]
        public void SetDoNotSellTypeDefault() 
            => PangleAdapter.SetDoNotSellOverride(PangleDoNotSellType.PangleDoNotSellTypeDefault);
    }
}
