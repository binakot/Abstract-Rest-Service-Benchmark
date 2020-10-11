import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;
import com.sun.net.httpserver.HttpServer;

import java.io.IOException;
import java.io.OutputStream;
import java.net.InetSocketAddress;

class App {
    public static void main(String[] argv) {
        try {
            HttpServer server = HttpServer.create(new InetSocketAddress("127.0.0.1", 8080), 0);
            server.createContext("/api/test", new HttpHandler() {
                public void handle(HttpExchange httpExchange) throws IOException {
                    httpExchange.sendResponseHeaders(200, 13);
                    OutputStream outputStream = httpExchange.getResponseBody();
                    outputStream.write("Hello, World!".getBytes());
                    outputStream.flush();
                    outputStream.close();
                }
            });
            server.start();
        } catch (IOException e) {
            // Ignore
        }
    }
}
