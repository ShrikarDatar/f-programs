open System
let mutable e=0
let mutable sum=0
printfn"Enter range"
e<-int(Console.ReadLine())
for i=1 to e do
    sum<-0
    for j=1 to i do
       if i%j=0 then
        sum<-sum+j
        if sum=i then
            printfn"%d"i  
Console.Read()               
