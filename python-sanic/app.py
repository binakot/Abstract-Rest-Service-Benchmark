import asyncio

import os
import uvloop

from sanic import Sanic
from sanic.response import text


os.environ['SANIC_KEEP_ALIVE_TIMEOUT'] = '360'
app = Sanic(configure_logging=False)


@app.route("/api/test")
async def test(request):
    return text("Hello, World!")


if __name__ == "__main__":
    asyncio.set_event_loop_policy(uvloop.EventLoopPolicy())
    app.run(host="0.0.0.0", port=8080, debug=False, workers=8, access_log=False)
