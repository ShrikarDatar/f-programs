open System
let ArrayIntersectionUnion=
    printfn"Enter number of elements in 1st array"
    let s1=int(Console.ReadLine())
    let mutable ele=0
    let arr1=Array.create s1 0
    printfn"Enter number of elements in 2nd array"
    let s2=int(Console.ReadLine())
    let arr2=Array.create s2 0
    printfn"Enter elements in 1st array"
    for i in 0..arr1.Length-1 do
        ele<-int(Console.ReadLine())
        arr1.[i]<-ele
    printfn"Enter elements in 2nd array"
    for i in 0..arr2.Length-1 do
    ele<-int(Console.ReadLine())
    arr2.[i]<-ele
    printfn"Intersection of array is: "
    let mutable flag=0
    for j in 0..arr1.Length-1 do
        for i in 0..arr2.Length-1 do
            if arr1.[j]=arr2.[i] then
                printfn"%d" arr1.[j]

    let mutable flag=0
    printfn"union is : "
    for j in 0..arr1.Length-1 do
        flag<-0
        for i in 0..arr2.Length-1 do
        if arr1.[j]=arr2.[i] then
            flag<-1
        if flag=0 then
            printfn"%d"arr1.[j]
    for i in 0..arr2.Length-1 do
        printfn"%d"arr2.[i]
              
ArrayIntersectionUnion
Console.ReadLine()
