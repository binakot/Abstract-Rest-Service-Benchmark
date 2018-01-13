'use strict';
const express = require('express');
const app = express();
const PORT = process.env.PORT || 8080;

app.get('/api/test', (req, res) => {
  res.type('text/plain');
  res.send('Hello, World!');
});

app.listen(PORT, () => console.log('Server start listen port: ' + PORT))
