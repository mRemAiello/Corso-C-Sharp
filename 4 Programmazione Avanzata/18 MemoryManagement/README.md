# Modulo 18 - Memory Management (Modulo 2)

Questo modulo raccoglie esempi pratici per gestire memoria e prestazioni in .NET:

- **Span**: slicing, proiezioni readonly e pooling con `Memory<T>`/`IMemoryOwner<T>`.
- **StackAlloc**: uso di `stackalloc`, `scoped` e blocchi `unsafe` per gestire buffer sullo stack e pinning.
- **Simd**: confronto tra operazioni scalari, `Vector<T>` e intrinsics hardware con `System.Runtime.Intrinsics`.
- **Lab**: parsing/serializzazione CSV a confronto tra approccio allocante e ottimizzato con `Span<T>` e buffer riutilizzabili.

Per eseguire gli esempi è sufficiente avviare il progetto `ProgrammazioneAvanzata` (target `net8.0`) e richiamare le classi nei rispettivi file. Ogni file espone un metodo `Run` che può essere invocato dalla `Main` o da un REPL.
