import { TagName } from "../tag/tag-name";
import { UserName } from "../user/user-name";

export interface App {
    id: number;
    name: string;
    displayName: string | null;
    description: string | null;
    image: string | null;
    createdAt: string;
    owner: UserName;
    tags: TagName[];
}
