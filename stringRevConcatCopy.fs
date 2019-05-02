open System
printfn"Enter the string to concat: "
let mutable string1=Console.ReadLine()
let mutable string2=Console.ReadLine()
let mutable string3=String.Concat(string1,string2)

printfn"string after concatenation: %s"string3

printfn"printing reverse string: "
let mutable length=String.length(string3)
for i=length-1 downto 0 do
    printfn"%c"string3.[i]
printfn""

printfn"Copy the String"
let mutable string4=String.Copy(string3)
printfn"copied string is %s"string3

printfn"printing alternate charchters: "
for i in 0..2..length-1 do
    printf "%c" string3.[i]
Console.ReadLine()
