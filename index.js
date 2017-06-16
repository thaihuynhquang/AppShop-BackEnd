var express = require('express');

var api = require('./routes/api');

// Initialize http server
var app = express();
var port = process.env.PORT || 4000;

//using midlewave
app.use("/api/images", express.static(__dirname + "/images"));

//lauch app
app.get("/test", (req, res, next) => {
    res.send(`<h1>Hello! I'm a server built by ExpressJS + NodeJS + MySQL.</h1>
              <img src="/api/images/type/301.jpg" alt="Mountain View" style="width:304px;height:228px;">
    `);
});

//configure path link
app.use("/api", api);


// Launch the server on port 3000
app.listen(port, function () {
    console.log(`App listening at PORT: ` + port);
});