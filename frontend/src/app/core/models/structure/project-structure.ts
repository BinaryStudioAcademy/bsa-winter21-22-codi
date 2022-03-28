import { FsNode } from "@core/models/structure/fs-node";

export interface ProjectStructure {
    id: string;
    children: FsNode[];
}
