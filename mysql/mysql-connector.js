var mysql = require('mysql2');

var pool = mysql.createPool({
    host: "localhost",
    user: "root",
    password: "",
    database: "db_app"
});

module.exports = {
    getConnection: function (callback) {
        pool.getConnection(function (err, connection) {
            callback(err, connection);
        });
    },
};