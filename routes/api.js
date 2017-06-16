var express = require('express');
var router = express.Router();

var bodyParser = require('body-parser');
var SQLquery = require('../mysql/mysql_query');

// create application/json parser
var jsonParser = bodyParser.json();

router.get('/product_by_type/:id_type/:page', function (req, res, next) {
    var id_type = req.params.id_type;
    var limit = 3;
    var page = parseInt(req.params.page ? req.params.page : 1);
    var offset = (page - 1) * limit;
    SQLquery.getProductByType(id_type, offset, limit, function (err, data) {
        if (err) {
            console.log(err);
            return res.send("LOI_TRUY_VAN");
        }
        else
            return res.json(data);
    });
});

router.get('/search/:key', function (req, res, next) {
    if (req.params.key && req.params.key.length > 2) {
        var keyword = req.params.key;
        SQLquery.getProductByName(keyword, function (err, data) {
            if (err) {
                console.log(err);
                return res.send("LOI_TRUY_VAN");
            }
            else
                return res.json(data);
        });
    }
    else
        return res.json([]);
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