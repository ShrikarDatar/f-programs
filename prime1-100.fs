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
//Check Prime number till 1 to n 
let primeN num=
    let mutable flag=0
    for i=2 to num do
        flag<-0
        for j=2 to i-1 do
            if i%j=0 then
                flag<-1
        if flag=0 && i>=2 then
            printfn"%d is  prime"i
        
printfn"Enter number till where to check for prime  :"
let n9=int(Console.ReadLine())
primeN n9

