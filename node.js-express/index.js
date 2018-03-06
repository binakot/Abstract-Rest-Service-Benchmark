'use strict';
const cluster = require('cluster');
const express = require('express');
const app = express();
const PORT = process.env.PORT || 8080;
const numCPUs = require('os').cpus().length;

if (cluster.isMaster) {
  // Fork workers.
  for (let i = 0; i < numCPUs; i++) {
    cluster.fork();
  }
} else {
  app.get('/api/test', (req, res) => {
    res.type('text/plain');
    res.send('Hello, World!');
  });

  app.listen(PORT, () => console.log('Server start listen port: ' + PORT));
}
