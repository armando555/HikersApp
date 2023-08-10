const fetch = require('node-fetch');
const { showLog } = require('./helpers');
const service = {};

// THIS IS THE VARIABLE THE YOU MUST CHANGE IF THE PORT IS DIFFERENT
//----------------------------------------------------------------------
const baseUrl = 'http://localhost:5299/';
//----------------------------------------------------------------------

service.calculate = async(input) => {
  const url = `${baseUrl}calculate`;
  const options = { 
    method: 'post', 
    ejectUnauthorized: false,
    body: JSON.stringify(input),
    headers: {'Content-Type': 'application/json'},
  }
  var answer = await makeRequest(url, options);
  console.log(url);
  console.log(options);
  return answer;
}


const makeRequest = async (url, options) => {
  try {
      var resp = await fetch(url, options || {});
      if (!resp.ok) {
        showLog('REQUEST URL: '+url, {'options': options, 'resp': resp});
        return {'err': 'Error obteniendo los datos'};
      }
      const json = await resp.json();
      return {'data': json};
  } catch(error) {
      showLog('REQUEST URL: '+url, error);
      return {'err': 'Error obteniendo los datos', 'err_service': error};
  }
}

module.exports = service