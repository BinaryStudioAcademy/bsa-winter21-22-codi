
export function IconLanguageHelper (extension: number) {

    switch (extension) {
        case 0:
            return 'assets/images/languages/csharp.svg';
        case 1:
            return 'assets/images/languages/web_project.svg';
        default:
            return 'assets/images/github_white.png';
    }
}
