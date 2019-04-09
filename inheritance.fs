open System
type Department() as d=
    class
    let mutable dname=""
    member d.accept()=
        printfn"Enter department name: "
        dname<-(Console.ReadLine())    
    member d.display()=
        printfn"Department name is %s"dname
    end
type student() as s=
    class
    inherit Department()
    let mutable sid=0
    let mutable sname=""
    member s.accept1()=
      printfn"Enter student ID: "
      sid<-int(Console.ReadLine())
      printfn"Enter student name: "
      sname<-(Console.ReadLine())
    member s.display1()=
        printfn"Student id is %d: "sid
        printfn "Student name is %s: "sname
    end
let obj=new student()
obj.accept()
obj.display()
obj.accept1()
obj.display1()
Console.Read()          
