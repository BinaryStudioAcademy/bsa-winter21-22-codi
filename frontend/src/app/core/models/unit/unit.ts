import { Lesson } from "@core/models/lesson/lesson";

export interface Unit {
    id: number;
    title: string;
    courseId: number;
    createdAt: Date;
    lessons: Lesson[];
}
