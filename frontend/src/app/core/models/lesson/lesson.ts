export interface Lesson {
    id: number;
    title: string;
    description?: string;
    dueDate: Date;
    isPublished: boolean;
    courseId: number;
    unitId?: number;
    projectId: number;
    createdAt: Date;
}
