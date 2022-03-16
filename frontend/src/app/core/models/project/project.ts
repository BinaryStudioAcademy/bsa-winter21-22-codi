export interface Project {
    id: number;
    title: string;
    description: string | null;
    isPublic: boolean;
    ownerId: number;
    createdAt: string;
}
