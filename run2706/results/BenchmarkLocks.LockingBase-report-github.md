```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.205
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method           | Mean       | Error     | StdDev    | Ratio | RatioSD | Completed Work Items | Lock Contentions | Code Size |
|----------------- |-----------:|----------:|----------:|------:|--------:|---------------------:|-----------------:|----------:|
| NoLock           |  0.6442 ns | 0.0446 ns | 0.0720 ns |  1.00 |    0.00 |                    - |                - |      22 B |
| UseLock          | 16.2632 ns | 0.2192 ns | 0.2050 ns | 24.89 |    2.51 |                    - |                - |     154 B |
| UseInterLockSpin | 10.4820 ns | 0.1245 ns | 0.1164 ns | 16.05 |    1.68 |                    - |                - |      98 B |
