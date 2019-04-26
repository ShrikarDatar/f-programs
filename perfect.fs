open System
let mutable n=0
let mutable count=0
printfn"Enter range"
n<-int(Console.ReadLine())
for i=1 to n do
    count<-0
    for j=1 to i do
       if i%j=0 then
        count<-count+j
        if count=i then
            printfn"%d"i  
Console.Read()               
