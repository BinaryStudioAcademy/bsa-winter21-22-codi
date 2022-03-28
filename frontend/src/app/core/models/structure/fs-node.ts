import { FsNodeType } from "@core/enums/fs-node-type";

export interface FsNode {
    type: FsNodeType,
    name?: string,
    fileId?: string,
    children: FsNode[]
}
