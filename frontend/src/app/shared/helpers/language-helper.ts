const GetLanguageByExtension = (extension: string) => {
    switch (extension) {
        case "cs":
        case "csproj":
            return "csharp";
        case "cpp":
            return "c";
        case "css":
            return "css";
        case "html":
            return "html";
        case "java":
            return "java";
        case "js":
            return "javascript";
        case "json":
            return "json";
        case "sql":
            return "sql";
        case "py":
            return "python";
        case "ts":
            return "typescript";
        case "yml":
            return "yaml";
        default:
            return undefined;
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
