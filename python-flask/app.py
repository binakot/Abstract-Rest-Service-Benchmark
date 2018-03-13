import logging

from flask import Flask


app = Flask(__name__)
app.logger.disabled = True

log = logging.getLogger('werkzeug')
log.disabled = True


@app.route("/api/test")
def hello():
    return "Hello, World!"
