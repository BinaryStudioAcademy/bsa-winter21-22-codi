const languages = [
    { extension: "cs", value: "csharp" },
    { extension: "csproj", value: "csharp" },
    { extension: "cpp", value: "c" },
    { extension: "css", value: "css" },
    { extension: "html", value: "html" },
    { extension: "java", value: "java" },
    { extension: "js", value: "javascript" },
    { extension: "json", value: "json" },
    { extension: "sql", value: "sql" },
    { extension: "py", value: "python" },
    { extension: "ts", value: "typescript" },
    { extension: "yml", value: "yaml"}
];

export const GetLanguageByExtension = (filename: string) => {
    if(filename) {
        let index = filename.lastIndexOf('.');
        let extension = filename.substring(index + 1, filename.length + 1);
        for (let item of languages) {
            if(item.extension === extension) {
                return item.value;
            }
        }
    }

    return undefined;
}
