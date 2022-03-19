using System.Text;
using System.Text.RegularExpressions;

namespace Codi.Core.Common.Helpers;

public static class UsernameHelper
{
    private static Regex pattern = new Regex("[A-Za-z0-9]+");
    public static string OmitSpecialCharacters(string username)
    {
        var updatedUsername = new StringBuilder();
        var matches = pattern.Matches(username);
        foreach (Match match in matches)
        {
            updatedUsername.Append(match.Value);
        }

        return updatedUsername.ToString();
    }
}