open System
let sum()=
    printfn"Enter the number:"
    let mutable n=int(Console.ReadLine())
    let mutable s=0
    let mutable dig=0
    while(n>0)do
        dig<-n%10
        s<-s+dig
        n<-n/10
    printfn"sum of digit is %i"s
sum()
Console.ReadLine()
