module Program

open Freya.Core
open Freya.Types.Http
open Freya.Machines.Http
open Freya.Routers.Uri.Template
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting

let sayHello = freya.Return <| Represent.text "Hello, World!"

let helloMachine = 
    freyaMachine {
        methods [GET]
        handleOk sayHello }

let helloRouter =
    freyaRouter {
        resource "/api/test" helloMachine }

let appBuilder (app: IApplicationBuilder) = 
    let owin = OwinMidFunc.ofFreya helloRouter
    app.UseOwin(fun p -> p.Invoke owin)

[<EntryPoint>]
let main _ =
    WebHostBuilder()
        .UseKestrel()
        .UseUrls("http://0.0.0.0:8080")
        .Configure(System.Action<_> (appBuilder >> ignore))
        .Build()
        .Run()
    0