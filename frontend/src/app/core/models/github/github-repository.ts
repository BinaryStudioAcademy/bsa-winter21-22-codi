import { GithubUser } from "@core/models/github/github-user";
import {Language} from "@core/enums/language";

export interface GithubRepository {
    name: string;
    url: string;
    owner: GithubUser;
    language: Language;
    stars: number;
    isPrivate: boolean;
    description?: string;
}
