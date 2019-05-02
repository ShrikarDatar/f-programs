open System
let array1 = [|for i in 1 .. 10 -> i|]

let getArraySum arr : int32 =
    let mutable sum =0
    printfn"Array Elements are as follows: "
    for i in 0 .. array1.Length-1 do
        printf "%i  " array1.[i]
        sum <- sum+array1.[i]
    sum

let ans = getArraySum array1
printfn "\nSum is %i" ans
Console.ReadLine()
