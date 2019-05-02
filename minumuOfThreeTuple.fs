open System
let n1 = int(Console.ReadLine())
let n2 = int(Console.ReadLine())
let n3 = int(Console.ReadLine())
let findMin tuple1 = 
    match tuple1 with
    |(x,y,z) -> if(x<y && x<z) then printfn "%A is minimum than %A & %A" x y z
                elif(y<x && y<z) then printfn "%A is minimum than %A & %A" y x z
                else printfn "%A is minimum than %A & %A" z x y

findMin (n1,n2,n3)
Console.ReadLine()
