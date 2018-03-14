# Abstract Rest Service Benchmark

## Requirements

* PORT: `8080`

* API request: `/api/test`

* API response: `Hello, World!` *(text/plain, UTF-8, 13 bytes)*

## Benchmark

Command for [WRK](https://github.com/wg/wrk):

```bash
$ wrk -t8 -c512 -d2m --timeout 10s --latency http://localhost:8080/api/test
```

---

## Results

|   | Service | Language | Framework | RPS |
| - | ------- | -------- | --------- | --- |
| 1 | [Java Light 4J](/java-light-4j/) | Java | java 9.0.4 | 401511.94 |
| 2 | [.Net Core](/dot-net-core-no-mvc/) | C# | dotnet 2.1.4 | 249758.46 |
| 3 | [Haskell Warp](/haskell/) | Haskell | ghc 7.10.3 | 191020.62 |
| 4 | [Rust Iron](/rust/) | Rust | rust 1.24.1 + iron 0.6.0 | 186726.17 |
| 5 | [Go Gorilla/Mux](/go/) | Go | go 1.9.4 | 131499.79 |
| 6 | [ASP.Net Core MVC](/dot-net-core/) | C# | dotnet 2.1.4 | 99091.85 |
| 7 | [NodeJS](/node.js/) | JavaScript | nodejs 8.9.4 | 94132.92 |
| 8 | [Python Sanic](/python-sanic/) | Python | python 3.5.2 + sanic 0.7.0 | 74854.41 |
| 9 | [NodeJS Express](/node.js-express/) | JavaScript | nodejs 8.9.4 + express 4.16.2 | 58769.29 |
| 10 | [Java Spring Boot](/java-spring-boot/) | Java | java 9.0.4 | 56253.12 |
| 11 | [.Net Core Freya](/dot-net-core-hopac-freya/) | F# | dotnet 2.1.4 | 49736.08 |
| 12 | [Python Aiohttp](/python-aiohttp/) | Python | python 3.5.2 + aiohttp 2.3.7 | 4603.01 |
| 13 | [Python Flask](/python-flask/) | Python | python 3.5.2 + flask 0.12.2 | 200.44 |

---

## Services

### .Net Core

Language: C#

Framework: .Net Core 2

Run:

```bash
$ dotnet restore
$ dotnet publish -c Release
$ export ASPNETCORE_ENVIRONMENT=Production
$ export ASPNETCORE_URLS=http://0.0.0.0:8080
$ cd ./dotNetCoreRestService/bin/Release/netcoreapp2.0/publish
$ dotnet dotNetCoreRestService.dll
```

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     8.95ms   30.34ms 474.95ms   94.12%
    Req/Sec    32.65k     7.53k   76.41k    87.22%
  Latency Distribution
     50%    1.93ms
     75%    2.12ms
     90%    3.88ms
     99%  171.71ms
  29975219 requests in 2.00m, 2.99GB read
Requests/sec: 249758.46
Transfer/sec:     25.49MB
```

---

### ASP.Net Core

Language: C#

Framework: .Net Core 2, ASP.NET Core MVC

Main tutorial: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api

Run:

```bash
$ dotnet restore
$ dotnet publish -c Release
$ export ASPNETCORE_ENVIRONMENT=Production
$ export ASPNETCORE_URLS=http://0.0.0.0:8080
$ cd ./dotNetCoreRestService/bin/Release/netcoreapp2.0/publish
$ dotnet dotNetCoreRestService.dll
```

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     9.87ms   25.89ms 563.33ms   95.83%
    Req/Sec    12.77k     2.82k   35.65k    85.48%
  Latency Distribution
     50%    4.60ms
     75%    6.07ms
     90%   11.07ms
     99%  159.56ms
  11900081 requests in 2.00m, 1.83GB read
Requests/sec:  99091.85
Transfer/sec:     15.59MB
```

---

### .Net Core Freya 

Language: F#

Framework: .Net Core 2, Freya

Run:

```bash
$ dotnet restore
$ dotnet publish -c Release
$ export ASPNETCORE_ENVIRONMENT=Production
$ export ASPNETCORE_URLS=http://0.0.0.0:8080
$ cd ./bin/Release/netcoreapp2.0/publish
$ dotnet dot-net-core-hopac-freya.dll
```

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    14.03ms   22.22ms 253.80ms   95.60%
    Req/Sec     6.34k     1.49k   11.31k    78.25%
  Latency Distribution
     50%    9.68ms
     75%   11.09ms
     90%   17.40ms
     99%  142.19ms
  5971487 requests in 2.00m, 831.45MB read
Requests/sec:  49736.08
Transfer/sec:      6.93MB
```

---

### Go Gorilla/Mux

Language: Go

Framework: Go SDK

Main tutorial: https://www.codementor.io/codehakase/building-a-restful-api-with-golang-a6yivzqdo

Run:

```bash
$ go build
$ ./go
```

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     6.31ms    8.82ms 205.24ms   88.57%
    Req/Sec    16.59k     4.12k   57.56k    68.34%
  Latency Distribution
     50%    3.81ms
     75%    7.12ms
     90%   16.60ms
     99%   42.44ms
  15792496 requests in 2.00m, 1.69GB read
Requests/sec: 131499.79
Transfer/sec:     14.42MB
```

---

### Java Light 4J

Language: Java

Framework: Oracle JDK 9

Main tutorial: https://github.com/networknt/light-example-4j/tree/master/demo

Run:

```bash
$ mvn clean install
$ java -jar target/service-example-0.1.0.jar
```

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     7.32ms   25.79ms 545.85ms   95.54%
    Req/Sec    52.35k    17.02k  137.38k    80.96%
  Latency Distribution
     50%  649.00us
     75%    3.80ms
     90%   10.81ms
     99%  148.73ms
  48218095 requests in 2.00m, 5.97GB read
Requests/sec: 401511.94
Transfer/sec:     50.93MB
```

---

### Java Spring Boot

Language: Java

Framework: Oracle JDK 9

Main tutorial: http://spring.io/guides/gs/rest-service

Run:

```bash
$ gradle clean build
$ java -jar build/libs/java-spring-boot-rest-service-1.0-SNAPSHOT.jar
```

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    14.93ms   28.96ms 894.46ms   93.82%
    Req/Sec     7.10k     2.45k   20.45k    72.47%
  Latency Distribution
     50%    8.15ms
     75%   15.47ms
     90%   29.98ms
     99%  133.78ms
  6755048 requests in 2.00m, 819.37MB read
Requests/sec:  56253.12
Transfer/sec:      6.82MB
```

---

### NodeJS

Language: JavaScript  

Framework: Node.js

Main tutorial: https://nodejs.org/api/http.html#http_class_http_server  

Run:  

```bash
$ node ./index.js
```  

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    13.40ms   36.18ms 491.10ms   93.96%
    Req/Sec    12.40k     2.82k   67.15k    90.69%
  Latency Distribution
     50%    4.95ms
     75%    5.93ms
     90%    8.90ms
     99%  192.05ms
  11306862 requests in 2.00m, 1.65GB read
Requests/sec:  94132.92
Transfer/sec:     14.09MB
```

---

### NodeJS Express

Language: JavaScript  

Framework: Node.js, Express

Main tutorial: http://expressjs.com/en/starter/hello-world.html  

Run:  

```bash
$ npm i
$ node ./index.js
```  

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    15.96ms   34.75ms 590.39ms   94.11%
    Req/Sec     7.71k     1.60k   11.56k    90.58%
  Latency Distribution
     50%    7.83ms
     75%    9.27ms
     90%   13.25ms
     99%  189.66ms
  7053065 requests in 2.00m, 1.43GB read
Requests/sec:  58769.29
Transfer/sec:     12.22MB
```

---

### Python Aiohttp

Language: Python

Framework: Python 3, Aiohttp

Main tutorial: https://aiohttp.readthedocs.io/en/stable/  

Run:  

```bash
$ pip install -r requirements.txt
$ python app.py
```  

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency   111.11ms    9.03ms 239.02ms   93.79%
    Req/Sec   597.05    126.48     1.29k    87.51%
  Latency Distribution
     50%  109.82ms
     75%  112.84ms
     90%  116.47ms
     99%  129.17ms
  552817 requests in 2.00m, 86.46MB read
Requests/sec:   4603.01
Transfer/sec:    737.20KB
```

---

### Python Flask

Language: Python

Framework: Python 3, Flask

Main tutorial: http://flask.pocoo.org/

Run:

```bash
$ pip install -r requirements.txt
$ FLASK_APP=app.py flask run --host=0.0.0.0 --port=8080
```

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency   182.08ms  699.71ms   6.62s    97.68%
    Req/Sec   215.45    181.60     0.94k    64.36%
  Latency Distribution
     50%   67.76ms
     75%   69.76ms
     90%   71.13ms
     99%    5.83s
  24068 requests in 2.00m, 3.83MB read
  Socket errors: connect 0, read 80, write 0, timeout 924
Requests/sec:    200.44
Transfer/sec:     32.69KB
```

---

### Python Sanic

Language: Python

Framework: Python 3, Sanic

Main tutorial: http://sanic.readthedocs.io/en/latest/  

Run:  

```bash
$ pip install -r requirements.txt
$ python app.py
```  

Results:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    13.38ms   30.03ms 413.05ms   94.39%
    Req/Sec     9.82k     5.34k   34.00k    74.06%
  Latency Distribution
     50%    6.16ms
     75%   10.80ms
     90%   17.10ms
     99%  173.38ms
  8996252 requests in 2.00m, 1.11GB read
Requests/sec:  74854.41
Transfer/sec:      9.42MB
```

---

### Python API Star

Language: Python

Framework: Python 3, API Star


Main tutorial: https://github.com/encode/apistar

Run:

```bash
pip install -r requirements.txt
uvicorn app:app --workers=8 --bind=0.0.0.0:8080 --pid=pid
```

Results:

---

### Haskell Warp

Language: Haskell

Framework: GHC

Main tutorial: http://taylor.fausak.me/2014/10/21/building-a-json-rest-api-in-haskell

Requirements:

* Install Haskell stack: https://docs.haskellstack.org/en/stable/README
* Install Cabal package: `cabal install Cabal-2.0.1.1`

Run:

```bash
$ stack setup
$ stack build
$ stack exec .stack-work/dist/**/build/test-exe/test-exe
```

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     8.54ms   26.91ms 490.86ms   94.97%
    Req/Sec    24.79k     7.55k   47.81k    75.31%
  Latency Distribution
     50%    2.42ms
     75%    3.34ms
     90%    8.94ms
     99%  164.24ms
  22940607 requests in 2.00m, 3.35GB read
Requests/sec: 191020.62
Transfer/sec:     28.60MB
```

---

### Rust Iron

Language: Rust

Framework: Rust SDK, Iron

Main tutorial: https://github.com/iron/router/blob/master/examples/simple.rs

Run:  

```bash
$ cargo build
$ cargo run --release
``` 

Result:

```text
Running 2m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency   709.82us    7.34ms 443.60ms   99.34%
    Req/Sec    27.47k    13.86k  110.07k    74.57%
  Latency Distribution
     50%  152.00us
     75%  261.00us
     90%  435.00us
     99%    1.20ms
  22425623 requests in 2.00m, 2.40GB read
  Socket errors: connect 0, read 8, write 0, timeout 0
Requests/sec: 186726.17
Transfer/sec:     20.48MB
```

---

## Hardware

```text
                          ./+o+-       root@ubuntu
                  yyyyy- -yyyyyy+      OS: Ubuntu 16.04 xenial
               ://+//////-yyyyyyo      Kernel: x86_64 Linux 4.4.0-62-generic
           .++ .:/++++++/-.+sss/`      Uptime: 26m
         .:++o:  /++++++++/:--:/-      Packages: 462
        o:+o+:++.`..```.-/oo+++++/     Shell: bash 4.3.48
       .:+o:+o/.          `+sssoo+/    CPU: 8x Intel Xeon CPU E5-2660 v3 @ 2.6GHz
  .++/+:+oo+o:`             /sssooo.   RAM: 313MiB / 16046MiB
 /+++//+:`oo+o               /::--:.
 \+/+o+++`o++o               ++////.
  .++.o+++oo+:`             /dddhhh.
       .+.o+oo:.          `oddhhhh+
        \+.++o+o``-````.:ohdhhhhh+
         `:o+++ `ohhhhhhhhyo++os:
           .o:`.syhhhhhhh/.oo++o`
               /osyyyyyyo++ooo+++/
                   ````` +oo+++o\:
                          `oo++.
```
