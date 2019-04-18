open System
type college()=
    class
    let mutable cid=0
    let mutable cname=""
    member c.accept()=
        printfn"Enter a college Id"
        cid<-int(Console.ReadLine())
        printfn"Enter a college name"
        cname<-(Console.ReadLine())
    member c.display()=
        printfn"College id is: %i"cid
        printfn"college name is: %s"cname
    end   
type student()=
    class
    inherit college()
    let mutable sno=0
    let mutable sname=""
    let mutable sage=0
    member s.accept1()=
            base.accept()
            printfn"Enter student number: "
            sno<-int(Console.ReadLine())
            printfn"Enter a age: "
            sage<-int(Console.ReadLine())
            printfn"Enter student name: "
            sname<-Console.ReadLine()
          
    member s.display1()=
            base.display()
            printfn"Enter student num %d"sno
            printfn"Enter student name %s"sname
            printfn"Enter student age %d"sage
    end

type result()=
    class
    inherit student()
    let mutable fno=0
    let mutable Rno=0
    member r.acc()=
        base.accept1()
        printfn"Enter a f# marks "
        fno<-int(Console.ReadLine())
        printfn"Enter a R marks "
        Rno<-int(Console.ReadLine())
    member s.disp()=
        base.display1()
        printfn"F# marks is: %d"fno
        printfn"R marks is: %d"Rno
    end
let obj=new result()
obj.acc()
obj.disp()
Console.ReadLine()                
                


