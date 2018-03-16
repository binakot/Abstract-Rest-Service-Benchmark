'use strict';
const cluster = require('cluster');
const http = require('http');
const url = require('url');
const PORT = process.env.PORT || 8080;
const numCPUs = require('os').cpus().length;

if (cluster.isMaster) {
  // Fork workers.
  for (let i = 0; i < numCPUs; i++) {
    cluster.fork();
  }
} else {
  http.createServer(function(req, res) {
    let rUrl = url.parse(req.url);
    if (rUrl.path == '/api/test') {
      res.writeHead(200, {'Content-Type': 'text/plain'});
      res.end('Hello, World!')
    } else {
      res.writeHead(404, {'Content-Type': 'text/plain'});
      res.end('Not found');
    }
  }).listen(PORT);
}
