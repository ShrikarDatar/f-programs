open System
let array1=[|3;45;32;1;34;56;78;98;77;2|]
let max=
    printfn"Array elements as follows: "
    let mutable max=0
    for i in 0..array1.Length-1 do
        printfn"%i" array1.[i]
        if(array1.[i]>max) then
            max<-array1.[i]
    max
let ans=max
printfn"max is %i" ans
Console.ReadLine()
