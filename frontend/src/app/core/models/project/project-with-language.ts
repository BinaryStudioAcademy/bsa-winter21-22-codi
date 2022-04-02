import { Language } from "@core/enums/language";

export interface ProjectWithLanguage {
    id: number;
    title: string;
    createdAt: Date;
    language: Language;
    isPublic: boolean;
    stars: number;
}
