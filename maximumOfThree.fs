open System
let mutable a=int(Console.ReadLine())
let mutable b=int(Console.ReadLine())
let mutable c=int(Console.ReadLine())
if a>=b && a>=c then
     printfn"maximum is %d:" a
elif b>=a && b>=c then
    printfn"maximum is %d" b
else
    printfn "Maximum is %d"c



Console.ReadLine()
