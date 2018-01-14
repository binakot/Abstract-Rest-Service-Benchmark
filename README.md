# Abstract Rest Service Benchmark

## Benchmark

The simple test with [AB](https://httpd.apache.org/docs/2.4/programs/ab.html):

```bash
$ ab -n 100000 -c 100 -H "Accept-Encoding: gzip, deflate" http://localhost:$PORT/api/test
```

---

## Results

|   | Service | Language | Framework | RPS |
| - | ------- | -------- | --------- | --- |
| 1 | [Go Rest Service (gorilla/mux)](/go-rest-service/) | Go | Go SDK 1.9.2 | 4103.44 |
| 2 | [Java Rest Service (Spring Boot)](/java-spring-boot-rest-service/) | Java | Oracle JDK8 | 2837.87 |
| 3 | [NodeJS Rest Service (Express)](/node.js-express/) | JS | NodeJS 8.9.4 LTS + Express 4.16.2 | 2801.68 |
| 4 | [.Net Core Rest Service (Native)](/dotNetCoreRestService/) | C# | .NET Core (ASP.NET Core 2.0) | 1942.79 |
| 5 | [NodeJS Rest Service (Native)](/node.js/) | JS | NodeJS 8.9.4 LTS | 1774.19 |

---

## Services

### .Net Core Rest Service

Language: C#

Framework: .NET Core (ASP.NET Core 2.0)

Main tutorial: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api

Run:

```bash
$ dotnet publish -c release -o published
$ dotnet dotNetCoreRestService.dll
```

Result:

```
Server Software:        Kestrel
Server Hostname:        localhost
Server Port:            5000

Document Path:          /api/test
Document Length:        13 bytes

Concurrency Level:      100
Time taken for tests:   51.472 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      14600000 bytes
HTML transferred:       1300000 bytes
Requests per second:    1942.79 [#/sec] (mean)
Time per request:       51.472 [ms] (mean)
Time per request:       0.515 [ms] (mean, across all concurrent requests)
Transfer rate:          277.00 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.3      0       8
Processing:     1   51  79.4     28    1605
Waiting:        0   40  64.3     23    1578
Total:          1   51  79.4     28    1605

Percentage of the requests served within a certain time (ms)
  50%     28
  66%     38
  75%     52
  80%     71
  90%     97
  95%    158
  98%    311
  99%    422
 100%   1605 (longest request)
```

---

### Spring Boot Rest Service

Language: Java

Framework: Oracle JDK8

Main tutorial: http://spring.io/guides/gs/rest-service

Run:

```bash
$ gradlew clean build
$ gradlew bootRun
```

Result:

```
Server Software:
Server Hostname:        localhost
Server Port:            8080

Document Path:          /api/test
Document Length:        13 bytes

Concurrency Level:      100
Time taken for tests:   35.238 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      14600000 bytes
HTML transferred:       1300000 bytes
Requests per second:    2837.87 [#/sec] (mean)
Time per request:       35.238 [ms] (mean)
Time per request:       0.352 [ms] (mean, across all concurrent requests)
Transfer rate:          404.62 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.3      0      17
Processing:     0   35  86.1      5    1834
Waiting:        0   25  68.7      3    1688
Total:          0   35  86.1      5    1834

Percentage of the requests served within a certain time (ms)
  50%      5
  66%     16
  75%     37
  80%     48
  90%     78
  95%    159
  98%    319
  99%    445
 100%   1834 (longest request)
```

---

### Go Rest Service

Language: Go

Framework: Go SDK 1.9.2

Main tutorial: https://www.codementor.io/codehakase/building-a-restful-api-with-golang-a6yivzqdo

Run:

```bash
$ go build
$ go-rest-service
```

Result:

```
Server Software:
Server Hostname:        localhost
Server Port:            8080

Document Path:          /api/test
Document Length:        13 bytes

Concurrency Level:      100
Time taken for tests:   24.370 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      11500000 bytes
HTML transferred:       1300000 bytes
Requests per second:    4103.44 [#/sec] (mean)
Time per request:       24.370 [ms] (mean)
Time per request:       0.244 [ms] (mean, across all concurrent requests)
Transfer rate:          460.84 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.3      0       8
Processing:     0   24   1.8     24      37
Waiting:        0   24   1.8     24      36
Total:          0   24   1.8     24      37

Percentage of the requests served within a certain time (ms)
  50%     24
  66%     24
  75%     24
  80%     25
  90%     26
  95%     28
  98%     30
  99%     31
 100%     37 (longest request)
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

Result:  

```
Server Software:
Server Hostname:        localhost
Server Port:            8080

Document Path:          /api/test
Document Length:        13 bytes

Concurrency Level:      100
Time taken for tests:   56.364 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      11400000 bytes
HTML transferred:       1300000 bytes
Requests per second:    1774.19 [#/sec] (mean)
Time per request:       56.364 [ms] (mean)
Time per request:       0.564 [ms] (mean, across all concurrent requests)
Transfer rate:          197.52 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.3      0      11
Processing:     1   56  92.1     17    1201
Waiting:        0   33  69.8      4    1187
Total:          1   56  92.1     17    1201

Percentage of the requests served within a certain time (ms)
  50%     17
  66%     41
  75%     66
  80%     90
  90%    168
  95%    244
  98%    350
  99%    429
 100%   1201 (longest request)
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

Result:  

```
Server Software:
Server Hostname:        localhost
Server Port:            8080

Document Path:          /api/test
Document Length:        13 bytes

Concurrency Level:      100
Time taken for tests:   35.693 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      21300000 bytes
HTML transferred:       1300000 bytes
Requests per second:    2801.68 [#/sec] (mean)
Time per request:       35.693 [ms] (mean)
Time per request:       0.357 [ms] (mean, across all concurrent requests)
Transfer rate:          582.77 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.3      0       9
Processing:    13   36   3.4     35     101
Waiting:       11   35   3.6     35      95
Total:         13   36   3.4     35     101

Percentage of the requests served within a certain time (ms)
  50%     35
  66%     36
  75%     36
  80%     36
  90%     37
  95%     39
  98%     44
  99%     48
 100%    101 (longest request)
```

---

## Hardware

Model: [iMac 18.3](https://support.apple.com/kb/SP760)

CPU: 3.4GHz quad-core Intel Core i5 (Turbo Boost up to 3.8GHz)

RAM: 8GB (two 4GB) of 2400MHz DDR4 memory

HDD: 1TB Fusion Drive
