open System
printfn "Enter a Number: "
let n1 = int(Console.ReadLine())
let getfactors no =
    for i=1 to no/2 do
        if(no%i=0) then
            printfn "%i" i
        
getfactors n1    
Console.ReadLine()
