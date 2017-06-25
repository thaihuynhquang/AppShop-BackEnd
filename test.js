//One day contains 86,400,000 millisecond

var today = new Date().getTime();
console.log("today: " + today);
console.log("**********");

var expDate = Date.parse("2017-08-20 21:51:23");
console.log("expDate: " + expDate);
console.log("**********");

var msec1Date = 86400000;
var warningTime = 5 * msec1Date;
console.log("warningTime: " + warningTime);
console.log("**********");

var kq = expDate - today;
console.log("ket qua: " + kq);
console.log("**********");

if (kq <= warningTime)
    console.log("Canh bao");
else
    console.log("khong canh bao");

/**
 * expDate: 1503240683000
**********
ket qua: 5025553099
**********
 */