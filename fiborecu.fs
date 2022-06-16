// For more information see https://aka.ms/fsharp-console-apps
open System
let rec fib2(n: int):int = 
    match n with
    | 0 | 1 -> n
    | 2 -> n-1
    | n -> fib2 (n - 1) + fib2 (n - 2)+ fib2 (n - 3)
    

[<EntryPoint>]
let main argv =
    Console.WriteLine("Introduce la cantidad de numeros de fibonacci que deseas ver")
    let valu = Console.ReadLine()
    let m=valu |> int
    Console.WriteLine("Secuencia Fibonacci:")
    for i in 0 ..(m-1) do
        let num=fib2 i |>(printf "%d,")
        Console.Write(num)
    0

