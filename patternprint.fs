open System
let n=int(Console.ReadLine())
printfn"patteren %d lines:"n
let mutable k=1
for i=1 to n do
    for j=1 to i do
        printfn"\t%d"k
        k<-k+1
    printfn"\t"
Console.ReadLine()
