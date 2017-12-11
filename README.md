# Abstract Rest Service Benchmark

## Benchmark

The simple test with [AB](https://httpd.apache.org/docs/2.4/programs/ab.html):

```bash
$ ab -n 100000 -c 10 -k -H "Accept-Encoding: gzip, deflate" http://localhost:$PORT/api/test
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

Concurrency Level:      10
Time taken for tests:   174.973 seconds
Complete requests:      100000
Failed requests:        0
Keep-Alive requests:    0
Total transferred:      15600000 bytes
HTML transferred:       1700000 bytes
Requests per second:    571.52 [#/sec] (mean)
Time per request:       17.497 [ms] (mean)
Time per request:       1.750 [ms] (mean, across all concurrent requests)
Transfer rate:          87.07 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.3      0       5
Processing:     1   17   3.2     16      55
Waiting:        1   14   2.9     14      41
Total:          1   17   3.2     16      55

Percentage of the requests served within a certain time (ms)
  50%     16
  66%     18
  75%     20
  80%     21
  90%     22
  95%     23
  98%     24
  99%     26
 100%     55 (longest request)
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

Concurrency Level:      10
Time taken for tests:   17.687 seconds
Complete requests:      100000
Failed requests:        0
Keep-Alive requests:    99004
Total transferred:      15095020 bytes
HTML transferred:       1300000 bytes
Requests per second:    5653.82 [#/sec] (mean)
Time per request:       1.769 [ms] (mean)
Time per request:       0.177 [ms] (mean, across all concurrent requests)
Transfer rate:          833.44 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.0      0       1
Processing:     0    2   6.2      1     320
Waiting:        0    2   6.2      1     320
Total:          0    2   6.2      1     320

Percentage of the requests served within a certain time (ms)
  50%      1
  66%      1
  75%      1
  80%      1
  90%      3
  95%      6
  98%     11
  99%     17
 100%    320 (longest request)
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
