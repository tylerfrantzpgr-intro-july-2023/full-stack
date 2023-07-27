# Summary of Benchmarking Results



## Switch (StatusCycler)

|             Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------- |---------:|---------:|---------:|-------:|----------:|
|         LaterToNow | 11.11 ns | 0.264 ns | 0.378 ns | 0.0057 |      96 B |
|       NowToWaiting | 11.17 ns | 0.262 ns | 0.358 ns | 0.0057 |      96 B |
| WaitingToCompleted | 11.02 ns | 0.264 ns | 0.426 ns | 0.0057 |      96 B |
| CompletedToWaiting | 11.28 ns | 0.241 ns | 0.337 ns | 0.0057 |      96 B |

## Modulo - (StatusCyclerTwo with inline array)

|             Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------- |---------:|---------:|---------:|-------:|----------:|
|         LaterToNow | 15.91 ns | 0.335 ns | 0.424 ns | 0.0081 |     136 B |
|       NowToWaiting | 15.95 ns | 0.360 ns | 0.571 ns | 0.0081 |     136 B |
| WaitingToCompleted | 15.66 ns | 0.352 ns | 0.598 ns | 0.0081 |     136 B |
| CompletedToWaiting | 15.91 ns | 0.362 ns | 0.825 ns | 0.0081 |     136 B |

## Modulo - (StatusCyclerTwo with static array)

|             Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------- |---------:|---------:|---------:|-------:|----------:|
|         LaterToNow | 13.49 ns | 0.307 ns | 0.478 ns | 0.0057 |      96 B |
|       NowToWaiting | 13.49 ns | 0.310 ns | 0.465 ns | 0.0057 |      96 B |
| WaitingToCompleted | 15.06 ns | 0.345 ns | 0.548 ns | 0.0057 |      96 B |
| CompletedToWaiting | 13.29 ns | 0.305 ns | 0.492 ns | 0.0057 |      96 B |

