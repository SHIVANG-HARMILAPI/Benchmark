``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.829 (1803/April2018Update/Redstone4)
Intel Core i7-4510U CPU 2.00GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
Frequency=2533197 Hz, Resolution=394.7581 ns, Timer=TSC
.NET Core SDK=2.1.701
  [Host] : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT
  Core   : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|      Method |          Mean |       Error |      StdDev | Rank |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|------------ |--------------:|------------:|------------:|-----:|-------:|-------:|-------:|----------:|
| UsingThread | 246,025.78 ns | 887.4155 ns | 786.6708 ns |    2 | 4.1504 | 0.2441 | 0.2441 |     368 B |
|   UsingTask |      65.55 ns |   0.7993 ns |   0.7085 ns |    1 | 0.0725 |      - |      - |     152 B |
