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
Time taken for tests:   52.670 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      15600000 bytes
HTML transferred:       1700000 bytes
Requests per second:    1898.61 [#/sec] (mean)
Time per request:       52.670 [ms] (mean)
Time per request:       0.527 [ms] (mean, across all concurrent requests)
Transfer rate:          289.24 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.3      0       7
Processing:     1   53  78.6     31    1719
Waiting:        1   40  62.0     25    1433
Total:          1   53  78.6     31    1719

Percentage of the requests served within a certain time (ms)
  50%     31
  66%     40
  75%     49
  80%     60
  90%     95
  95%    167
  98%    306
  99%    427
100% 1719 (longest request)
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
Document Length:        13 bytes

Concurrency Level:      100
Time taken for tests:   36.404 seconds
Complete requests:      100000
Failed requests:        0
Total transferred:      14600000 bytes
HTML transferred:       1300000 bytes
Requests per second:    2746.97 [#/sec] (mean)
Time per request:       36.404 [ms] (mean)
Time per request:       0.364 [ms] (mean, across all concurrent requests)
Transfer rate:          391.66 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.3      0      15
Processing:     0   36 102.1      4    2560
Waiting:        0   25  79.7      3    2112
Total:          0   36 102.1      4    2560

Percentage of the requests served within a certain time (ms)
  50%      4
  66%     10
  75%     21
  80%     37
  90%     84
  95%    179
  98%    376
  99%    537
100% 2560 (longest request)
```

### Go Rest Service

> TODO

### NodeJS Rest Service

> TODO

---

## Hardware

Model: [iMac 18.3](https://support.apple.com/kb/SP760)

CPU: 3.4GHz quad-core Intel Core i5 (Turbo Boost up to 3.8GHz)

RAM: 8GB (two 4GB) of 2400MHz DDR4 memory

HDD: 1TB Fusion Drive
