open System
let Armstrong num l=
    let mutable n=0
    let mutable rem=0
    let mutable temp=num
    let mutable mult=1
    while temp>0 do
        rem<-temp%10
        mult<-1
        for i=1 to l do
            mult<-mult*rem
        n<-n+mult
        temp<-temp/10
    if n=num then
        printfn"%d is Armstrong number"num
    else
        printfn"%d is not armstrong number"num
printfn"Enter a number to check armstrong num: "
let n4=Console.ReadLine()
let len=n4.Length
let no=int(n4)
Armstrong no len
Console.ReadLine()
