open System
let average (a,b,c) =
    let sum:int32 = a+b+c
    printfn "Sum of %A,%A & %A is %i" a b c sum
    let avg = sum/3
    printfn "Average is: %i" avg
average (3,4,5)
Console.ReadLine()
