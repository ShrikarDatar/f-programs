open System
printfn"Enter a numuber: "
let n=int(Console.ReadLine())
let palindrome n=
     let mutable temp=n
     let mutable sum=0
     let mutable rem=0
     while(temp>0) do
        rem<-temp%10
        sum<-sum*10+rem
        temp<-temp/10
        if sum=n then
            printfn"%d is palindrome"n
        else
            printfn"%d is not palindrome"n
palindrome n                  
Console.ReadLine() 
            
