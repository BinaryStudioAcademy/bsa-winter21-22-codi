export interface CreateLesson {
    title: string;
    description?: string;
    courseId: number;
    unitId?: number;
    templateId?: number;
    dueDate: Date;
}
