using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.Constants
{
    internal static class DotNetCoreConstants
    {
        public const string CSharpProjectFileExtension = "csproj";
        public const string FSharpProjectFileExtension = "fsproj";

        public const string AssemblyNameXPathExpression = "/Project/PropertyGroup/AssemblyName";
        public const string DotnetSdkDockerImageName = "mcr.microsoft.com/dotnet/sdk";
        public const string DotnetSdkDockerImageTag = "6.0";
        public const string DotnetRuntimeDockerImageName = "mcr.microsoft.com/dotnet/runtime";
        public const string DotnetRuntimeDockerImageTag = "6.0";
    }
}
