import logging

from flask import Flask


app = Flask(__name__)
app.logger.disabled = True

log = logging.getLogger('werkzeug')
log.disabled = True


@app.route("/api/test")
def hello():
    return "Hello, World!"


if __name__ == '__main__':
    app.run(host='0.0.0.0', port=8080, debug=False, processes=8)
