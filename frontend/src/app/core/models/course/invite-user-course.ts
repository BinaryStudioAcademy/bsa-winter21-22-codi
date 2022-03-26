import {CourseRole} from "@core/models/course/course-role";

export interface InviteUserCourse {
    userId: number;
    courseId: number;
    courseRole: CourseRole;
}
