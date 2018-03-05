package com.melnichuk.handler;

import com.networknt.server.HandlerProvider;
import io.undertow.Handlers;
import io.undertow.server.HttpHandler;
import io.undertow.util.Methods;

public class DemoHandlerProvider implements HandlerProvider {

    public HttpHandler getHandler() {
        return Handlers.routing().add(Methods.GET, "api/test", new TextHandler());
    }
}
