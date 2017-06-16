var mysql = require('mysql2');
var mysqlConnector = require('../mysql/mysql-connector');

module.exports = {
    getProductByType: function (id_type, offset, limit, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }

            connection.query('SELECT p.*, t.name as nameType, GROUP_CONCAT(i.link) AS images FROM product p inner join product_type t ON t.id = p.id_type INNER JOIN images i ON i.id_product = p.id WHERE id_type = ? group by p.id LIMIT ?,? ', [id_type, offset, limit], function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);

                var product = results;
                var len = product.length;
                if (len > 0) {
                    for (var i = 0; i < len; i++) {
                        var assignees = product[i]['images'].split(",");
                        product[i]['images'] = assignees;
                    }
                    return callback(null, product);
                }
                return callback(null, product);
            })
        });
    },

    getProductByName: function (name, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }

            connection.query('SELECT p.*, GROUP_CONCAT(i.link) AS images FROM product p INNER JOIN images i ON p.id = i.id_product where name like ? group by p.id', ['%' + name + '%'], function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);

                var product = results;
                var len = product.length;
                if (len > 0) {
                    for (var i = 0; i < len; i++) {
                        var assignees = product[i]['images'].split(",");
                        product[i]['images'] = assignees;
                    }
                    return callback(null, product);
                }
                return callback(null, product);
            })
        });
    },
};

/**
 *  getUserAccounts: function (callback) {
        mysqlConnector.getConnection(function (err, connection) {
            if(err) return callback(err, null);
            connection.query('SELECT * FROM users', function (error, results, fields) {
                connection.release();
                if (error) return callback(error, null);
                return callback(null, results);

                // Don't use the connection here, it has been returned to the pool.
            });
        });
    },

    function name: function (paramsQuery, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) return callback(err, null);
            
            connection.query('queryString', [paramsQuery], function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);
                
                if(results > 1)
                    //Business handling
                    return callback(null, array);
                //results === 0 reuturn array []
                return callback(null, array);
            })
        });
    },
 */