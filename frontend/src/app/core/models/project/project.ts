export interface Project {
    id: number;
    title: string;
    description?: string;
    isPublic: boolean;
    ownerId: number;
    createdAt: string;
}
