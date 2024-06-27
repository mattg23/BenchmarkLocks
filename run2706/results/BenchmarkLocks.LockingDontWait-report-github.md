```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.205
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method           | Mean       | Error     | StdDev    | Ratio | RatioSD | Completed Work Items | Lock Contentions | Code Size |
|----------------- |-----------:|----------:|----------:|------:|--------:|---------------------:|-----------------:|----------:|
| NoLock           |  0.6826 ns | 0.0125 ns | 0.0098 ns |  1.00 |    0.00 |                    - |                - |      22 B |
| UseLock          | 16.2230 ns | 0.2951 ns | 0.2464 ns | 23.75 |    0.59 |                    - |                - |     210 B |
| UseInterLockSpin | 10.4850 ns | 0.2188 ns | 0.2047 ns | 15.38 |    0.29 |                    - |                - |      54 B |
