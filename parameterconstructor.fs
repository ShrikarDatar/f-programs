open System
type student(no,name)=
    class
    let mutable no=no
    let mutable name=name
    
    member s.display()=
        printfn"student number is: %d"no
        printfn"Student name is: %s"name
    end
let obj=new student(12,"SHRIKAR")
obj.display()
Console.ReadLine()
