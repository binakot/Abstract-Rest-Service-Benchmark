from sanic import Sanic
from sanic.response import text

app = Sanic()


@app.route("/api/test")
async def test(request):
    return text("Hello, world!")


if __name__ == "__main__":
    app.run(host="0.0.0.0", port=8000)
