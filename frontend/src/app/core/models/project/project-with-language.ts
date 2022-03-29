import {ProjectLanguage} from "@core/models/project/project-language";

export interface ProjectWithLanguage {
    id: number;
    title: string;
    createdAt: Date;
    language: ProjectLanguage;
}
