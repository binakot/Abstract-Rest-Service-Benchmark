import asyncio
import uvloop

from aiohttp import web


async def handle(request):
    return web.Response(text="Hello, world!")


app = web.Application()
app.router.add_get('/api/test', handle)

asyncio.set_event_loop_policy(uvloop.EventLoopPolicy())
web.run_app(app)
