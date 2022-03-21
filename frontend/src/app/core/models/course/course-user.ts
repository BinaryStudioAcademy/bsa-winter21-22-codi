import {User} from "@core/models/user/user";
import {CourseRole} from "@core/models/course/course-role";

export interface CourseUser {
    user: User;
    courseRole: CourseRole;
}
