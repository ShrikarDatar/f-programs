open System
let swap=
    printfn"Enter number 1"
    let mutable a=int(Console.ReadLine())
    printfn"Enter number 2"
    let mutable b=int(Console.ReadLine())
    let temp=a
    a<-b
    b<temp
    printfn"After swapping a:%d b:%d"a b
swap
Console.ReadLine()     
