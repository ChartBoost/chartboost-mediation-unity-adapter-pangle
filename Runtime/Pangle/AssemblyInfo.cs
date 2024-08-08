using System.Runtime.CompilerServices;
using Chartboost.Mediation.Pangle;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.PangleAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.PangleAssemblyInfoIOS)]

namespace Chartboost.Mediation.Pangle
{
    internal class AssemblyInfo
    {
        public const string PangleAssemblyInfoAndroid = "Chartboost.Mediation.Pangle.Android";
        public const string PangleAssemblyInfoIOS = "Chartboost.Mediation.Pangle.IOS";
    }
}
