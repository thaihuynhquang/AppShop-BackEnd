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

                var product = [];
                if (results.length > 0) {
                    product = results;
                    var len = product.length;
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

                var product = [];
                if (results.length > 0) {
                    product = results;
                    var len = product.length;
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

    getProductType: function (callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }

            connection.query('Select * from product_type', function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);

                //Business handling
                var type = [];
                if (results.length > 0) {
                    type = results;
                    return callback(null, type);
                }

                return callback(null, type);
            })
        });
    },

    getTopProducts: function (callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }

            connection.query('SELECT p.id,p.name as name ,p.id_type as idType, t.name as nameType, p.price, p.description, GROUP_CONCAT(i.link) AS images FROM product p LEFT JOIN images i ON p.id = i.id_product inner join product_type t ON t.id = p.id_type where p.new = 1 group by p.id LIMIT 0,6', function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);

                //Business handling
                var product = [];
                if (results.length > 0) {
                    product = results;
                    var len = product.length;
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

    createUser: function (email, password, name, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }

            connection.query('INSERT INTO users set ?', { id: null, email: email, password: password, name: name }, function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);

                if (results)
                    //Business handling
                    return callback(null, results);
                //
                return callback(null, null);
            })
        });
    },

    getUser: function (email, password, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }

            connection.query('SELECT u.email, u.name, u.address, u.phone FROM users u where email = ? and password = ?', [email, password], function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);

                if (results.length == 1)
                    //Business handling
                    return callback(null, results);
                //
                return callback(null, null);
            })
        });
    },

    getUserByEmail: function (email, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }
            
            connection.query('SELECT u.id, u.email, u.name, u.address, u.phone FROM users u where email = ?', [email], function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);
                
                if(results.length == 1)
                    //Business handling
                    return callback(null, results);
                //
                return callback(null, null);
            })
        });
    },

    updateUser: function (name, phone, address, email, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }
            
            connection.query('UPDATE users SET name=?, phone=?, address=? WHERE email =?', [name, phone, address, email], function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);
                
                if(results)
                    //Business handling
                    return callback(null, results);
                //
                return callback(null, null);
            })
        });
    },

    getBillByEmail: function (email, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }
            
            connection.query('SELECT b.id, b.date_order, b.status, b.total FROM bill b INNER JOIN users u ON u.id=b.id_customer where u.email =?', [email], function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);
                
                if(results.length > 0)
                    //Business handling
                    return callback(null, results);
                //
                return callback(null, results);
            })
        });
    },

    createBill: function (id_customer, date_order, total, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }
            
            connection.query('INSERT INTO bill set ?', { id_customer: id_customer, date_order: date_order, total: total }, function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);
                
                if(results)
                    //Business handling
                    return callback(null, results);
                //
                return callback(null, null);
            })
        });
    },

    getProductByArrID: function (arrID, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }
            
            connection.query('Select * FROM product where id IN (' + arrID + ')', function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);
                
                if(results)
                    //Business handling
                    return callback(null, results);
                //
                return callback(null, results);
            })
        });
    },

    createBillDetail: function (arrBillDetail, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }
            
            connection.query('INSERT INTO bill_detail (id_bill,id_product,quantity,price) values ?', [arrBillDetail], function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);
                
                if(results)
                    //Business handling
                    return callback(null, results);
                //
                return callback(null, null);
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

    functionname: function (paramsQuery, callback) {
        mysqlConnector.getConnection(function (err, connection) {
            //Error handling
            if (err) {
                //end connection
                connection.release();
                return callback(err, null);
            }
            
            connection.query('queryString', [paramsQuery], function (error, results, fields) {
                //end connection
                connection.release();
                //Error handling
                if (error) return callback(error, null);
                
                if(results > 0)
                    //Business handling
                    return callback(null, results);
                //
                return callback(null, results);
            })
        });
    },
 */