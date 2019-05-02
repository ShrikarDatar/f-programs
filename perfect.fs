open System
printfn"Enter a numuber: "
let n=int(Console.ReadLine())
let mutable sum=0
let perfect n=
    for i=1 to n-1 do
        if n%i=0 then
            sum<-sum+i
    if sum=n then
        printfn"%d is perfect" n
    else
        printfn"%d is not perfect"n
perfect n
Console.ReadLine() 
            
