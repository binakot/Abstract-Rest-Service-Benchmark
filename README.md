# Abstract Rest Service Benchmark

## Requiremnts

* PORT: `8080`

* API request: `/api/test`

* API response: `Hello, World!` *(text/plain, UTF-8, 13 bytes)*

## Benchmark

Command for [WRK](https://github.com/wg/wrk):

```bash
$ wrk -t8 -c512 -d10m --timeout 1m --latency http://localhost:port/api/test
```

---

## Results

|   | Service | Language | Framework | RPS |
| - | ------- | -------- | --------- | --- |
| 1 | [Java Light 4J](/java-light-4j/) | Java | java 9.0.4 | 475553.57 |
| 2 | [Haskell Warp](/haskell/) | Haskell | ghc 7.10.3 | 213436.16 |
| 3 | [Go Gorilla/Mux](/go/) | Go | go 1.9.4 | 153889.88 |
| 4 | [Java Spring Boot](/java-spring-boot/) | Java | java 9.0.4 | 70646.27 |
| 5 | [.Net Core](/dot-net-core/) | C# | dotnet 2.1.4 | 57162.40 |
| 6 | [Rust Iron](/rust/) | Rust | rust 1.24.1 + iron 0.6.0 | 24573.25 |
| 7 | [NodeJS](/node.js/) | JavaScript | nodejs 8.9.4 | 18434.01 |
| 8 | [NodeJS Express](/node.js-express/) | JavaScript | nodejs 8.9.4 + express 4.16.2 | 9897.75 |
| 9 | [Python Sanic](/python-sanic/) | Python | python 3.5.2 + sanic 0.7.0 | 6158.24 |
| 10 | [Python Aiohttp](/python-aiohttp/) | Python | python 3.5.2 + aiohttp 2.3.7 | 4713.28 |
| 11 | [Python Flask](/python-flask/) | Python | python 3.5.2 + flask 0.12.2 | 171.78 |

---

## Services

### .Net Core Native

Language: C#

Framework: .NET Core (ASP.NET Core 2)

Main tutorial: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api

Run:

```bash
$ dotnet publish -c release -o release
$ dotnet release/dotNetCoreRestService.dll
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

### Go Gorilla/Mux

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
Running 10m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     7.10ms   19.10ms 444.99ms   93.62%
    Req/Sec    27.47k     9.44k   83.13k    71.80%
  Latency Distribution
     50%    2.12ms
     75%    3.23ms
     90%   11.23ms
     99%  102.01ms
  128101480 requests in 10.00m, 18.73GB read
Requests/sec: 213436.16
Transfer/sec:     31.96MB
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
Running 10m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     5.79ms   17.07ms 361.51ms   94.22%
    Req/Sec    61.07k    19.75k  184.17k    74.83%
  Latency Distribution
     50%  609.00us
     75%    3.33ms
     90%   11.34ms
     99%   92.78ms
  285371526 requests in 10.00m, 35.35GB read
Requests/sec: 475553.57
Transfer/sec:     60.32MB
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
Running 10m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    12.30ms   22.02ms   1.05s    92.97%
    Req/Sec     8.90k     2.58k   23.11k    70.55%
  Latency Distribution
     50%    7.42ms
     75%   13.41ms
     90%   25.77ms
     99%  107.94ms
  42394116 requests in 10.00m, 5.02GB read
Requests/sec:  70646.27
Transfer/sec:      8.57MB
```

---

### NodeJS Native

Language: JavaScript  

Framework: Node.js

Main tutorial: https://nodejs.org/api/http.html#http_class_http_server  

Run:  

```bash
$ node ./index.js
```  

Result:

```text
Running 10m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    27.76ms    1.97ms 291.39ms   95.47%
    Req/Sec     2.32k   183.03     3.38k    66.94%
  Latency Distribution
     50%   27.48ms
     75%   28.09ms
     90%   28.81ms
     99%   33.67ms
  11062139 requests in 10.00m, 1.62GB read
Requests/sec:  18434.01
Transfer/sec:      2.76MB
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
Running 10m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    51.68ms    4.00ms 373.69ms   92.76%
    Req/Sec     1.24k   108.08     1.94k    88.47%
  Latency Distribution
     50%   51.44ms
     75%   52.59ms
     90%   53.93ms
     99%   63.87ms
  5939587 requests in 10.00m, 1.21GB read
Requests/sec:   9897.75
Transfer/sec:      2.06MB
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
Running 10m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency   108.61ms    6.84ms 235.63ms   88.72%
    Req/Sec   607.27    112.78     1.29k    90.23%
  Latency Distribution
     50%  107.01ms
     75%  110.69ms
     90%  115.46ms
     99%  124.29ms
  2828423 requests in 10.00m, 442.37MB read
Requests/sec:   4713.28
Transfer/sec:    754.86KB
```

---

### Python Flask

Language: Python

Framework: Python 3, Flask

Main tutorial: http://flask.pocoo.org/

Run:

```bash
$ pip install -r requirements.txt
$ FLASK_APP=app.py flask run
```

Result:

```text
Running 10m test @ http://localhost:5000/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     1.01s     3.45s    0.92m    91.12%
    Req/Sec   239.42    269.75     1.90k    95.32%
  Latency Distribution
     50%   68.82ms
     75%   72.28ms
     90%    1.04s
     99%   17.41s
  103085 requests in 10.00m, 16.42MB read
  Socket errors: connect 512, read 711, write 609, timeout 1
Requests/sec:    171.78
Transfer/sec:     28.01KB
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
Running 10m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    83.11ms    5.97ms 385.64ms   90.15%
    Req/Sec   773.56    252.68     1.89k    79.55%
  Latency Distribution
     50%   82.53ms
     75%   84.57ms
     90%   88.25ms
     99%   96.46ms
  3695508 requests in 10.00m, 465.21MB read
Requests/sec:   6158.24
Transfer/sec:    793.84KB
```

---

### Rust Iron

Language: Rust

Framework: Rust SDK, Iron

Main tutorial: https://github.com/iron/router/blob/master/examples/simple.rs

Run:  

```bash
$ cargo build
$ cargo run
``` 

Result:

```text
Running 10m test @ http://localhost:8080/api/test
  8 threads and 512 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency     3.65ms   23.55ms   1.39s    98.42%
    Req/Sec     3.61k     5.56k   25.48k    87.28%
  Latency Distribution
     50%    1.63ms
     75%    2.28ms
     90%    3.36ms
     99%   49.96ms
  14747271 requests in 10.00m, 1.58GB read
  Socket errors: connect 0, read 187, write 1133, timeout 0
Requests/sec:  24573.25
Transfer/sec:      2.70MB
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
