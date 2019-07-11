using System.Reflection;

namespace LittleBlazors.Components.Charts
{
    public static class AssemblyPathHelper
    {
        public static string GetScriptPath(string scriptFileName)
        {
            return $"{GetScriptRoot()}/{scriptFileName}";
        }

        private static string GetScriptRoot()
        {
            return $"{GetAssemblyWebRoot()}/lib";
        }

        private static string GetAssemblyWebRoot()
        {
            return $"_content/{ThisAssemblyName}";
        }

        private static string ThisAssemblyName => Assembly.GetExecutingAssembly().GetName().Name;
    }
}
