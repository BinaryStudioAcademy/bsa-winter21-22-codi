namespace Codi.Core.Common.Helpers;

public static class RepositoryHelper
{
    private static string baseUrl = "https://github.com";
    public static string GetRepositoryNameFromUrl(string repoUrl)
    {
        var name = repoUrl.Substring(baseUrl.Length + 1).Split('/')[1];
        return name;
    }

    public static string GetRepositoryOwnerFromUrl(string repoUrl)
    { 
        var owner = repoUrl.Substring(baseUrl.Length + 1).Split('/')[0];
        return owner;
    }
}