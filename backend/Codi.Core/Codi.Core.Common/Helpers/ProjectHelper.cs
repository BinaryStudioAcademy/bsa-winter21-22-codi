using Codi.Core.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Core.Common.Helpers
{
    public static class ProjectHelper
    {
        public static Language? LanguageComparation(string languageString)
        {
            return languageString switch
                {
                    "C#" => Language.CSharp,
                    "HTML" => Language.HTML,
                    "Python" => Language.Python,
                    "F#" => Language.FSharp,
                    _ => null
                };
        }
        
    }
}
