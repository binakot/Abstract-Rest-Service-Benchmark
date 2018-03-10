# How to build and run
On first machine
1. Navigate to repository folder
2. `cd ./dot-net-core-no-mvc`
3. `dotnet restore`
4. `dotnet publish -c Release`
5. `cd ./dotNetCoreRestService/bin/Release/netcoreapp2.0/publish`
6. `chmod +x ./run.sh`
7. `./run.sh`

On second machine
1. `wrk -t8 -c512 -d10m --timeout 1m --latency http://{FIRST_MACHINE_IP:PORT}/api/test` (by default 8080 port and any assigned IP)