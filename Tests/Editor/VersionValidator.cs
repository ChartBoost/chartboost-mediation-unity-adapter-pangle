using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.Pangle;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.pangle";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.Pangle";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, PangleAdapter.AdapterUnityVersion);
    }
}
