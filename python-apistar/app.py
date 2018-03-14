from apistar import Route
from apistar.frameworks.asyncio import ASyncIOApp as App


async def welcome():
    return 'Hello, World!'


routes = [
    Route('/api/test', 'GET', welcome),
]

app = App(routes=routes)

if __name__ == '__main__':
    app.main()
