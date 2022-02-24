import { User } from "@core/models/user/user";

export interface Course {
    id: number;
    name: string;
    displayName?: string;
    description?: string;
    avatar?: string;
    owner: User;
    createdAt: Date;
}
