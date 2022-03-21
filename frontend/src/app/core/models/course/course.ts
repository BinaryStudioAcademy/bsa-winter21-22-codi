import { User } from "@core/models/user/user";
import {CourseUser} from "@core/models/course/course-user";

export interface Course {
    id: number;
    name: string;
    displayName?: string;
    description?: string;
    avatar?: string;
    owner: User;
    createdAt: Date;
    courseUsers: CourseUser[];
}
