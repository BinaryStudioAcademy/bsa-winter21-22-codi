export const regexs = {
    title: /^[A-Za-z0-9!#$%&'*/=?^_`|~., ]+$/,
    username: /^[A-Za-z0-9]+$/,
    name: /^[A-Za-z]+$/,
    email: /^([\w]+(?:[\.!#\$%'&\*\/=\?\^_`\|~\-][\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-zA-Z0-9]{2,6}(?:\.[a-z]{2})?)$/,
    password: /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d!"#$%&'()*+,\-./:;<=>?@[\]^_`{|}~]{8,35}$/,
    githubUrl: /https:\/\/github\.com\/[A-Za-z0-9-]+\/[A-Za-z0-9_.-]+/
};
