import { Language } from "@core/enums/language";

export function IconLanguageHelper (language: Language) {

    switch (language) {
        case Language.CSharp:
            return 'assets/images/languages/csharp.svg';
        case Language.HTML:
            return 'assets/images/languages/web_project.svg';
        case Language.Python:
            return 'assets/images/languages/python.svg';
        case Language.Goloang:
            return 'assets/images/languages/goloang.svg';
        case Language.FSharp:
            return 'assets/images/languages/fsharp.svg';
        default:
            return null;
    }
}
