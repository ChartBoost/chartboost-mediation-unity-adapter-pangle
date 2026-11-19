using Chartboost.Editor;
using Chartboost.Mediation.Pangle;
using NUnit.Framework;

namespace Chartboost.Mediation.Pangle.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.pangle";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.Pangle";
        
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, PangleAdapter.AdapterUnityVersion);
    }
}
