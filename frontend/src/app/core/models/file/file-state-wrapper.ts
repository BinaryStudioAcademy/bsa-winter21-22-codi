import { File } from "@core/models/file/file";

export interface FileStateWrapper {
    file: File,
    isChanged: boolean;
}
