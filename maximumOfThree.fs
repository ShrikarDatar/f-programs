open System
let mutable A=3
let mutable B=5
let mutable C=10
if A>=B && A>=C then
    printfn"%d is greater"A
elif B>=A && B>=C then
    printfn"%d is greater" B
else printfn"%d is gretaer"C
Console.ReadLine()         
