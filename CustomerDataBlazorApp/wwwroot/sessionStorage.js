function setUserNameInSessionStorage(userName) {
    sessionStorage.setItem("userName", userName);
}

function getUserNameFromSessionStorage() {
    return sessionStorage.getItem("userName");
}

function removeUserFromSessionStorage() {
    sessionStorage.removeItem("userName");
}
