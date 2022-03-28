const GetLanguageByExtension = (extension: string) => {
    switch (extension) {
        case "cs":
        case "csproj":
            return "csharp";
        case "cpp":
            return "c";
        case "js":
            return "javascript";
        case "py":
            return "python";
        case "ts":
            return "typescript";
        case "yml":
            return "yaml";
        default:
            return extension;
    }
}

export const GetLanguageByFileName = (filename: string) => {
    if(filename) {
        let index = filename.lastIndexOf('.');
        let extension = filename.substring(index + 1, filename.length + 1);
        return GetLanguageByExtension(extension);
    }

    return undefined;
}
