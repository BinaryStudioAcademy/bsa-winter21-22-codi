import {ProjectLanguage} from "@core/models/project/project-language";

export function IconLanguageHelper (extension: ProjectLanguage) {

    switch (extension) {
        case ProjectLanguage.CSharp:
            return 'assets/images/languages/csharp.svg';
        case ProjectLanguage.JavaScript:
            return 'assets/images/languages/java.svg';
        default:
            return extension;
    }
}
