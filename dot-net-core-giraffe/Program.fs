module App

open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Giraffe

let webApp = GET >=> route "/api/test" >=> json "Hello, World!"

let configureApp (app : IApplicationBuilder) =
    app.UseGiraffe(webApp)

let configureServices (services : IServiceCollection) =
    services.AddGiraffe() |> ignore

[<EntryPoint>]
let main _ =
    WebHostBuilder()
        .UseKestrel()
        .UseIISIntegration()
        .Configure(Action<IApplicationBuilder> configureApp)
        .ConfigureServices(configureServices)
        .Build()
        .Run()
    0