open System
printfn"Enter the string to concat: "
let mutable string1=Console.ReadLine()
let mutable string2=Console.ReadLine()
let mutable string3=String.Concat(string1,string2)

printfn"string after concatenation: %s"string3

printfn"printing reverse string: "
let mutable length=String.length(string1)
for i=length-1 downto 0 do
    printfn"%c"string1.[i]
printfn""

printfn"Copy the String"
let mutable string4=String.Copy("shree")
printfn"copied string is %s"string4
Console.ReadLine()
