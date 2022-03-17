import { TagName } from "../tag/tag-name";
import { UserName } from "../user/user-name";

export interface App {
    id: number;
    name: string;
    displayName?: string;
    description?: string;
    image?: string;
    createdAt: string;
    owner: UserName;
    tags: TagName[];
}
