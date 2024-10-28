window.localStorageHelper = {
    setItem: function (key, value) {
        localStorage.setItem(key, value);
    },
    getItem: function (key) {
        return localStorage.getItem(key);
    },
    removeItem: function (key) {
        localStorage.removeItem(key);
    },
    saveUserSession: function (email, firstName) {
        this.setItem("UserEmail", email);
        this.setItem("UserFirstName", firstName);
    },
    logSession: function () {
        console.log("Session Data:");
        console.log("UserEmail:", this.getItem("UserEmail"));
        console.log("UserFirstName:", this.getItem("UserFirstName"));
    }
};
