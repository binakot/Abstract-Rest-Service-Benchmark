'use strict';
const http = require('http');
const url = require('url');
const PORT = process.env.PORT || 8080;

http.createServer(function (req, res) {
  let rUrl = url.parse(req.url);
  if (rUrl.path == '/api/test') {
    res.writeHead(200, {'Content-Type': 'text/html'});
    res.end('Hello World!')
  } else {
    res.writeHead(404, {'Content-Type': 'text/html'});
    res.end('Not found');
  }
}).listen(PORT);
