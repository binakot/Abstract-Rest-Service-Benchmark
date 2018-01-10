'use strict';
const http = require('http');
const url = require('url');
const PORT = process.env.PORT || 8080;

http.createServer(function (req, res) {
  let rUrl = url.parse(req.url, true);
  if (rUrl.path == '/api/test') {
    res.writeHead(200, {'Content-Type': 'text/html'});
    res.write('Hello World!')
  } else {
    res.writeHead(404, {'Content-Type': 'text/html'});
    res.write('Not found');
  }
  res.end();
}).listen(PORT);
