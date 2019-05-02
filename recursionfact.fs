open System
let n=int(Console.ReadLine())
let rec fact n =
    if n=1 then
        1
    else
        n*fact(n-1)
let res=fact 5
printfn "%d"res
Console.ReadLine()
//Check factorial of number 
let factorial num=
    let mutable fact=1
    for i=1 to num do
        fact<-fact*i
    printfn"%d factorial = %d"num fact    

printfn"Enter a number to calculate its factorial  :"
let n1=int(Console.ReadLine())
factorial n1
