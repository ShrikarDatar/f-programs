open System

let mutable flag=false

printfn "Prime Numbers from 1 to 100 are as follows: "
for n=1 to 1 do
    flag <- false
    for i=1 to n do
        if n%i<>0 && i<>1 && i<>n then
            flag <- true

    if flag=true then
        printfn "%d "n
   
Console.Read()
