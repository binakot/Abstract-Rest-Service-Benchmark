# Abstract Rest Service Benchmark

## Benchmark

The simple test with [AB](https://httpd.apache.org/docs/2.4/programs/ab.html):

```bash
$ ab -n 100000 -c 100 -H "Accept-Encoding: gzip, deflate" http://localhost:$PORT/api/test
```

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
Document Length:        17 bytes

Concurrency Level:      100
Time taken for tests:   53.444 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      15600000 bytes
HTML transferred:       1700000 bytes
Requests per second:    1871.11 [#/sec] (mean)
Time per request:       53.444 [ms] (mean)
Time per request:       0.534 [ms] (mean, across all concurrent requests)
Transfer rate:          285.05 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.2      0      11
Processing:     1   53  83.7     31    1845
Waiting:        1   41  66.5     25    1789
Total:          2   53  83.7     31    1845

Percentage of the requests served within a certain time (ms)
  50%     31
  66%     39
  75%     47
  80%     58
  90%    100
  95%    178
  98%    326
  99%    454
 100%   1845 (longest request)
```

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
Document Length:        17 bytes

Concurrency Level:      100
Time taken for tests:   34.372 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      15600000 bytes
HTML transferred:       1700000 bytes
Requests per second:    2909.35 [#/sec] (mean)
Time per request:       34.372 [ms] (mean)
Time per request:       0.344 [ms] (mean, across all concurrent requests)
Transfer rate:          443.22 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.2      0       7
Processing:     0   34  85.1      4    1576
Waiting:        0   24  67.2      3    1320
Total:          1   34  85.1      4    1576

Percentage of the requests served within a certain time (ms)
  50%      4
  66%     12
  75%     27
  80%     42
  90%     85
  95%    175
  98%    325
  99%    449
 100%   1576 (longest request)
```

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
Document Length:        16 bytes

Concurrency Level:      100
Time taken for tests:   24.143 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      12400000 bytes
HTML transferred:       1600000 bytes
Requests per second:    4141.95 [#/sec] (mean)
Time per request:       24.143 [ms] (mean)
Time per request:       0.241 [ms] (mean, across all concurrent requests)
Transfer rate:          501.56 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.3      0      10
Processing:     0   24   1.1     24      36
Waiting:        0   24   1.1     24      36
Total:          0   24   1.1     24      36

Percentage of the requests served within a certain time (ms)
  50%     24
  66%     24
  75%     24
  80%     24
  90%     25
  95%     25
  98%     25
  99%     26
 100%     36 (longest request)
```

### NodeJS Rest Service

> TODO

---

## Hardware

Model: [iMac 18.3](https://support.apple.com/kb/SP760)

CPU: 3.4GHz quad-core Intel Core i5 (Turbo Boost up to 3.8GHz)

RAM: 8GB (two 4GB) of 2400MHz DDR4 memory

HDD: 1TB Fusion Drive
