# Abstract Rest Service Benchmark

## Benchmark

The simple test with [AB](https://httpd.apache.org/docs/2.4/programs/ab.html):

```bash
$ ab -n 100000 -c 10 -k -H "Accept-Encoding: gzip, deflate" http://localhost:5000/api/test
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

> TODO

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
