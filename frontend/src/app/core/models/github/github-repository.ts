import { GithubUser } from "@core/models/github/github-user";

export interface GithubRepository {
    name: string;
    url: string;
    owner: GithubUser;
}
