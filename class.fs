open System
type student()=
    class
    let mutable no=0
    let mutable name=""
    member s.accept()=
        printfn"Enter student num:"
        no<-int(Console.ReadLine())
        printfn"Enter student name:"
        name<-(Console.ReadLine())
    member s.display()=
        printfn"student no is %d"no
        printfn"student name is %s"name
    end
let object =new student()
object.accept()
object.display()
Console.ReadLine()
