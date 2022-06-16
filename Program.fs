// For more information see https://aka.ms/fsharp-console-apps
open System
let fib5 n = 
    let mutable last = 0
    let mutable next = 1
    let mutable sigu = 1
    seq {
        0
        1
        1
        for i in 1 .. (n-3) do
            let temp = last + next + sigu
            last <- next
            next <- sigu
            sigu <- temp
            sigu
      }

[<EntryPoint>]
let main argv =
    Console.WriteLine("Introduce la cantidad de numeros que deseas de la secuencia de fibonacci")
    let valu = Console.ReadLine()
    let m=valu |> int
    Console.Write(m)
    Console.WriteLine("Secuencia Fibonacci:")
    let run = fib5 m|> Seq.iter (printf "%d,")
    Console.WriteLine(run)
    0
  