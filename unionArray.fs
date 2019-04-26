open System
let array3 = [| 1; 2; 3; 4|]
let array4 = [| 5 .. 9 |]
printfn "Union of array:"
let array5 = Array.append array3 array4
printfn "%A" array5
Console.ReadLine()
