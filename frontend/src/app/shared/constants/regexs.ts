export const regexs = {
  username: /^[A-Za-z0-9]+$/,
  email: /^[a-zA-Z0-9]{1}[-a-zA-Z0-9._]{1,33}[a-zA-Z0-9]{1}@[a-zA-Z0-9]{1,17}[.][a-zA-Z]{1,17}$/,
  password: /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!"#$%&'()*+,\-./:;<=>?@[\]^_`{|}~])[A-Za-z\d!"#$%&'()*+,\-./:;<=>?@[\]^_`{|}~]{8,35}$/,
};
