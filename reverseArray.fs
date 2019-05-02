open System

let array3 = [|for i in 1 .. 10 -> i|]

let dispReverse = 
    printfn "Array Elements before reverse: "
    for i in 0 .. array3.Length-1 do
        printf "%i  " array3.[i]

    printfn "\nArray Elements after reverse: "
    let revarr = [|for i in array3.Length-1 .. -1 .. 0 -> array3.[i]|]
    for i in 0 .. revarr.Length-1 do
        printf "%i  " revarr.[i]

dispReverse
Console.ReadLine()
   
