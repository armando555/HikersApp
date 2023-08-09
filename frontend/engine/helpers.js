const helpers = {};
const moment = require("moment");
const {promisify} = require('util');
const typeInfo = {1: 'ERROR', 2: 'LOG'};

helpers.showLog = (target, info, type) => {
    type = type || 1;
    console.log(`------------ ${typeInfo[type]} | ${target} -----------`);
    console.log(`${moment().format('LLL')} - ${target}: `,info);
    console.log(`------------ ${typeInfo[type]} | ${target} -----------`);
}

module.exports = helpers;