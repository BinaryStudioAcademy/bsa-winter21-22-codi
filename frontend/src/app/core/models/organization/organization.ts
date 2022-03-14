import { Course } from "@core/models/course/course";

export interface Organization {
    id: number;
    name: string;
    ownerId: number;
    createdAt: Date;
    courses: Course[];
}
