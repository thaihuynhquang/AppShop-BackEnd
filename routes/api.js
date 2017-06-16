var express = require('express');
var router = express.Router();

var bodyParser = require('body-parser');
var SQLquery = require('../mysql/mysql_query');
var crypto = require('crypto');
var jwt = require('jsonwebtoken');
var secret = '13110148';

// create application/json parser
var jsonParser = bodyParser.json();

//get today
var gettoday = function () {
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1;
    var yyyy = today.getFullYear();
    var hh = today.getHours();
    var min = today.getMinutes();
    var ss = today.getSeconds();

    if (dd < 10) {
        dd = '0' + dd
    }

    if (mm < 10) {
        mm = '0' + mm
    }
    return today = yyyy + '/' + mm + '/' + dd + ' ' + hh + ':' + min + ':' + ss;
}
//end get today

router.get('/product_by_type/:id_type/:page', function (req, res, next) {
    var id_type = req.params.id_type;
    var page = parseInt(req.params.page ? req.params.page : 1);
    var limit = 3;
    var offset = (page - 1) * limit;
    SQLquery.getProductByType(id_type, offset, limit, function (err, data) {
        if (err) {
            console.log(err);
            res.send("LOI_TRUY_VAN");
        }
        else
            res.json(data);
    });
});

router.get('/search/:key', function (req, res, next) {
    if (req.params.key && req.params.key.length > 2) {
        var keyword = req.params.key;
        SQLquery.getProductByName(keyword, function (err, data) {
            if (err) {
                console.log(err);
                res.send("LOI_TRUY_VAN");
            }
            else
                res.json(data);
        });
    }
    else
        res.json([]);
});

router.get('/init', function (req, res, next) {
    SQLquery.getTopProducts(function (err, data) {
        if (err) {
            console.log(err);
            res.send("LOI_TRUY_VAN");
        }
        else {
            var product = data;
            SQLquery.getProductType(function (err, data) {
                if (err) {
                    console.log(err);
                    res.send("LOI_TRUY_VAN");
                }
                else {
                    var type = data;
                    res.json({ type: type, product: product });
                }
            });
        }
    });
});

router.post('/register', jsonParser, function (req, res, next) {
    if (!req.body) return res.sendStatus(400);
    var json = req.body;
    var email = (json.email);
    var name = (json.name);
    var password = (json.password);
    if (email != '' && name != '' && password != '') {
        var passCrypto = crypto.createHash('md5').update(password.toString()).digest("hex");
        SQLquery.createUser(email, passCrypto, name, function (err, data) {
            if (err) {
                console.log(err);
                res.send("LOI_TRUY_VAN");
            }
            else {
                if (data)
                    res.send("THANH_CONG");
                else
                    res.send("KHONG_THANH_CONG");
            }
        });
    }
    else {
        res.send("KHONG_THANH_CONG");
    }
});

router.post('/login', jsonParser, function (req, res, next) {
    if (!req.body) return res.sendStatus(400);
    var json = req.body;
    var email = (json.email);
    var password = (json.password);
    if (email !== '' && password !== '') {
        var passCrypto = crypto.createHash('md5').update(password.toString()).digest("hex");
        SQLquery.getUser(email, passCrypto, function (err, data) {
            if (err) {
                console.log(err);
                res.send("LOI_TRUY_VAN");
            }
            else {
                if (data) {
                    var token = jwt.sign({
                        iat: (new Date()).getTime(),
                        expire: ((new Date()).getTime() + 172800000), //2 days
                        email: email
                    }, secret, { expiresIn: 172800000 });
                    var array = { token: token, user: data[0] };
                    res.json(array);
                }
                else
                    res.send("SAI_THONG_TIN_DANG_NHAP");
            }
        });
    }
    else
        res.send("SAI_THONG_TIN_DANG_NHAP");
});

router.post('/check_login', jsonParser, function (req, res, next) {
    if (!req.body) return res.sendStatus(400);
    var json = req.body;
    var token = (json.token);
    try {
        jwt.verify(token, secret, function (err, decoded) {
            if (err)
                return res.send("TOKEN_KHONG_HOP_LE");
            if (decoded.expire < (new Date()).getTime())
                return res.send("TOKEN_HET_HAN");
            var email = decoded.email;
            SQLquery.getUserByEmail(email, function (err, data) {
                if (err) {
                    console.log(err);
                    res.send("LOI_TRUY_VAN");
                }
                else {
                    if (data) {
                        var token = jwt.sign({
                            iat: (new Date()).getTime(),
                            expire: ((new Date()).getTime() + 172800000), //2 days
                            email: email
                        }, secret, { expiresIn: 172800000 });
                        var array = { token: token, user: data[0] };
                        res.json(array);
                    }
                    else
                        res.send("TOKEN_KHONG_HOP_LE");
                }
            });
        });
    } catch (error) {
        res.send("TOKEN_KHONG_HOP_LE");
    }
});

router.post('/refresh_token', jsonParser, function (req, res, next) {
    if (!req.body) return res.sendStatus(400);
    var json = req.body;
    var token = (json.token);
    try {
        jwt.verify(token, secret, function (err, decoded) {
            if (err)
                return res.send("TOKEN_KHONG_HOP_LE");
            if (decoded.expire < (new Date()).getTime())
                return res.send("TOKEN_HET_HAN");
            var email = decoded.email;
            var newtoken = jwt.sign({
                iat: (new Date()).getTime(),
                expire: ((new Date()).getTime() + 172800000), //2 days
                email: email
            }, secret, { expiresIn: 172800000 });
            res.send(newtoken);
        });
    } catch (err) {
        return res.send("TOKEN_KHONG_HOP_LE");
    }
});

router.post('/change_info', jsonParser, function (req, res, next) {
    if (!req.body) return res.sendStatus(400);
    var json = req.body;
    var token = (json.token);
    var name = (json.name);
    var phone = (json.phone);
    var address = (json.address);
    try {
        jwt.verify(token, secret, function (err, decoded) {
            if (err)
                return res.send("TOKEN_KHONG_HOP_LE");
            if (decoded.expire < (new Date()).getTime())
                return res.send("TOKEN_HET_HAN");
            var email = decoded.email;
            SQLquery.updateUser(name, phone, address, email, function (err, data) {
                if (err) {
                    console.log(err);
                    res.send("LOI_TRUY_VAN");
                }
                else {
                    if (data) {
                        SQLquery.getUserByEmail(email, function (err, data) {
                            if (err) {
                                console.log(err);
                                res.send("LOI_TRUY_VAN");
                            }
                            else {
                                if (data) {
                                    var array = data[0];
                                    res.json(array);
                                }
                                else
                                    res.send("TOKEN_KHONG_HOP_LE");
                            }
                        });
                    }
                    else
                        res.send("TOKEN_KHONG_HOP_LE");
                }
            });
        });
    } catch (error) {
        res.send("TOKEN_KHONG_HOP_LE");
    }
});

router.post('/order_history', jsonParser, function (req, res, next) {
    if (!req.body) return res.sendStatus(400);
    var json = req.body;
    var token = (json.token);
    try {
        jwt.verify(token, secret, function (err, decoded) {
            if (err)
                return res.send("TOKEN_KHONG_HOP_LE");
            if (decoded.expire < (new Date()).getTime())
                return res.send("TOKEN_HET_HAN");
            var email = decoded.email;
            SQLquery.getBillByEmail(email, function (err, data) {
                if (err) {
                    console.log(err);
                    res.send("LOI_TRUY_VAN");
                }
                else {
                    if (data) {
                        res.json(data);
                    }
                    else
                        res.send("TOKEN_KHONG_HOP_LE");
                }
            });
        });
    } catch (err) {
        return res.send("TOKEN_KHONG_HOP_LE");
    }
});

router.post('/cart', jsonParser, function (req, res, next) {
    if (!req.body) return res.sendStatus(400);
    var json = req.body;
    var token = (json.token);
    var arrayDetail = (json.arrayDetail);
    try {
        jwt.verify(token, secret, function (err, decoded) {
            if (err)
                return res.send("TOKEN_KHONG_HOP_LE");
            if (decoded.expire < (new Date()).getTime())
                return res.send("TOKEN_HET_HAN");
            var email = decoded.email;
            var arrTotalMoneyonProduct = arrayDetail.map(function (e) { return e.price * e.quantity; });
            var totalMoneyonBill = arrTotalMoneyonProduct.length ? arrTotalMoneyonProduct.reduce(function (a, b) { return a + b; }) : 0;
            var todate = gettoday();
            var arrID = arrayDetail.map(function (el) { return el.id; });
            SQLquery.getUserByEmail(email, function (err, data) {
                if (err) {
                    console.log(err);
                    res.send("LOI_TRUY_VAN_getUserByEmail");
                }
                else {
                    if (data) {
                        var id_user = data[0].id;
                        SQLquery.createBill(id_user, todate, totalMoneyonBill, function (err, results) {
                            if (err) {
                                console.log(err);
                                res.send("LOI_TRUY_VAN_createBill");
                            }
                            else {
                                if (results) {
                                    var id_bill = results.insertId;
                                    SQLquery.getProductByArrID(arrID, function (err, data) {
                                        if (err) {
                                            console.log(err);
                                            res.send("LOI_TRUY_VAN_getProductByArrID");
                                        }
                                        else {
                                            if (data) {
                                                var soluong = 0;
                                                var dem = 0;
                                                var newbills = [];
                                                data.forEach(function (i) {
                                                    var price = i['price'];
                                                    arrayDetail.forEach(function (el) {
                                                        if (el.id === i['id']) {
                                                            soluong = el['quantity'];
                                                            newbills.push([id_bill, i['id'], soluong, price]);
                                                        }
                                                    });
                                                });
                                                SQLquery.createBillDetail(newbills, function(err, data) {
                                                    if(err) {
                                                        console.log(err);
                                                        res.send("LOI_TRUY_VAN_createBillDetail");
                                                    }
                                                    else {
                                                        if(data) {
                                                            res.send("THANH_CONG");
                                                        }
                                                        else
                                                            res.send("KHONG_THANH_CONG");
                                                    }
                                                });
                                            }
                                            else
                                                res.send("KET_QUA_RONG");
                                        }
                                    });
                                }
                                else
                                    res.send("LOI_TRUY_VAN_createBill");
                            }
                        });
                    }
                    else
                        res.send("TOKEN_KHONG_HOP_LE");
                }
            });

        });
    } catch (err) {
        return res.send("LOI_KHONG_RO");
    }
});

module.exports = router;

/**
 * router.get('/test', function (req, res, next) {
        SQLquery.getUserAccounts(function (err, data) {
            if (err) {
                console.log(err);
                return res.send("LOI_TRUY_VAN");
            }
            else
                return res.json(data);
        });
    });
 */