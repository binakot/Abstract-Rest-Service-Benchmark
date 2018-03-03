# Abstract Rest Service Benchmark

## Requiremnts

* PORT: `8080`

* API request: `/api/test`

* API response: `Hello, World!` *(text/plain, UTF-8, 13 bytes)*

## Benchmark

The test with [wrk](https://github.com/wg/wrk):

```bash
$ wrk -t8 -c512 -d10m --timeout 1m --latency http://localhost:port/api/test
```

---

## Results

|   | Service | Language | Framework | RPS |
| - | ------- | -------- | --------- | --- |
| 1 | [Go Gorilla/Mux](/go/) | Go | go 1.9.4 linux/amd64 | 153889.88 |
| 1 | [.Net Core Native](/dot-net-core/) | C# | dotnet 2.1.4 | 57162.40 |

---

## Services

### .Net Core Native Rest Service

Language: C#

Framework: .NET Core (ASP.NET Core 2)

Main tutorial: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api

Run:

```bash
$ dotnet publish -c release -o published
$ dotnet published/dotNetCoreRestService.dll
```

Result:

```text
Running 10m test @ http://localhost:5000/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    12.67ms   17.50ms 282.63ms   92.66%
    Req/Sec     7.29k     1.86k   31.28k    75.47%
  Latency Distribution
     50%    7.71ms
     75%    9.47ms
     90%   20.57ms
     99%  100.31ms
  34302965 requests in 10.00m, 5.27GB read
Requests/sec:  57162.40
Transfer/sec:      8.99MB
```

---

### Go Gorilla/Mux Rest Service

Language: Go

Framework: Go SDK

Main tutorial: https://www.codementor.io/codehakase/building-a-restful-api-with-golang-a6yivzqdo

Run:

```bash
$ go build
$ go-rest-service
```

Result:

```text
Running 10m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     5.34ms    7.32ms 209.12ms   88.57%
    Req/Sec    19.33k     4.71k   50.04k    64.94%
  Latency Distribution
     50%    3.46ms
     75%    6.16ms
     90%   13.90ms
     99%   35.12ms
  92346022 requests in 10.00m, 9.89GB read
Requests/sec: 153889.88
Transfer/sec:     16.88MB
```

---

### Haskell Warp Rest Service

Language: Haskell

Framework: warp 3.2.13

Main tutorial: http://taylor.fausak.me/2014/10/21/building-a-json-rest-api-in-haskell/

Requirements:

* Install Haskell stack: https://docs.haskellstack.org/en/stable/README/
* Install Cabal package: `cabal install Cabal-2.0.1.1`

Run:

```bash
$ stack image container
```

> TODO Change to native run (not in Docker)

---

### Java Light 4J Rest Service

Language: Java

Framework: Oracle JDK8

Main tutorial: https://github.com/networknt/light-example-4j/tree/master/demo

Run:

```bash
$ mvn clean install
$ java -jar target/service-example-0.1.0.jar
```

---

### Java Spring Boot Rest Service

Language: Java

Framework: Oracle JDK8

Main tutorial: http://spring.io/guides/gs/rest-service

Run:

```bash
$ gradlew clean build
$ gradlew bootRun
```

---

### NodeJS Native Rest Service

Language: JavaScript  

Framework: Node.js 8.9.4 LTS  

Main tutorial: https://nodejs.org/api/http.html#http_class_http_server  

Run:  

```bash
$ node ./index.js
```  

---

### NodeJS Express Rest Service

Language: JavaScript  

Framework: Node.js 8.9.4 LTS + Express 4.16.2

Main tutorial: http://expressjs.com/en/starter/hello-world.html  

Run:  

```bash
$ npm i  
$ node ./index.js  
```  

---

### Python Aiohttp Rest Service

Language: Python 3.5  

Framework: aiohttp 2.3.7, uvloop 0.9.1

Main tutorial: https://aiohttp.readthedocs.io/en/stable/  

Run:  

```bash
$ pip install -r requirements.txt
$ python app.py
```  

---

### Python Flask Rest Service

Language: Python 3.5

Framework: Flask 0.12.2

Main tutorial: http://flask.pocoo.org/

Run:

```bash
$ pip install -r requirements.txt
$ FLASK_APP=app.py flask run
```

---

### Python Sanic Rest Service

Language: Python 3.5  

Framework: Sanic 0.7.0, uvloop 0.9.1

Main tutorial: http://sanic.readthedocs.io/en/latest/  

Run:  

```bash
$ pip install -r requirements.txt
$ python app.py
```  

---

### Rust Iron Rest Service

Language: RUST

Framework: iron 0.6.0

Main tutorial: https://github.com/iron/router/blob/master/examples/simple.rs

Run:  

```bash
$ docker build -t rustest .
$ docker run -p 8080:8080 -it rustest:latest
``` 

> TODO Change to native run (not in Docker)

---

## Hardware

### Home Station

Model: [iMac 18.3](https://support.apple.com/kb/SP760)

CPU: 3.4GHz quad-core Intel Core i5 (Turbo Boost up to 3.8GHz)

RAM: 8GB (two 4GB) of 2400MHz DDR4 memory

HDD: 1TB Fusion Drive

### Real Server

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
