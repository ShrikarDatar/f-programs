open System
let n=int(Console.ReadLine())
let rec fact n =
    if n=1 then
        1
    else
        n*fact(n-1)
let res=fact 5
printfn "%d"res
Console.ReadLine()
