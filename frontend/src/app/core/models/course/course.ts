export interface Course {
    id: number;
    name: string;
    displayName?: string;
    description?: string;
    avatar?: string;
    ownerId: number;
    createdAt: Date;
}
