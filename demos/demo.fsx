
#r "../src/PrettyFsi/bin/Debug/netstandard2.0/PrettyFsi.dll"

open System
open PrettyFsi

PrettyFsi.addPrinters(fsi, TableMode.Implicit)


module Ex1 =
    type Test1 =
        { name: string
          degree: int
          weight: float
          birthDate: DateTime
          ids: int list }

    [
        { name = "Hans G�nther"
          degree = 23
          weight = 56.3
          birthDate = DateTime(2000, 12, 15, 23, 45, 00)
          ids = [ 1; 23; 45; 23; 556 ]
        }
        { name = "Jenny Lawrence"
          degree = 2
          weight = 56.3
          birthDate = DateTime(2000, 12, 15, 23, 45, 00)
          ids = [ 14; 63; 5; 8856 ]
        }
    ]

    (*
              name              | degree  | weight  | birthDate            | ids                   | 
        ---------------------------------------------------------------------------------------------
        0 :   "Hans G�nther"    |     23  |   56.3  | 15.12.2000 23:45:00  | [1; 23; 45; 23; 556]  | 
        1 :   "Jenny Lawrence"  |      2  |   56.3  | 15.12.2000 23:45:00  | [14; 63; 5; 8856]     | 
    *)


module Ex2 =

    [
        [ "name", "Hans G�nther" :> obj
          "degree", 23 :> obj
          "weight", 56.3 :> obj
          "birthDate", DateTime(2000, 12, 15, 23, 45, 00) :> obj
          "ids", [ 1; 23; 45; 23; 556 ] :> obj
        ]
        [ "name", "Jenny Lawrence" :> obj
          "degree", 2 :> obj
          "weight", 56.3 :> obj
          "birthDate", DateTime(2000, 12, 15, 23, 45, 00) :> obj
          "ids", [ 14; 63; 5; 8856 ] :> obj
        ]
    ]

    (*
              name              | degree  | weight  | birthDate            | ids                   | 
        ---------------------------------------------------------------------------------------------
        0 :   "Hans G�nther"    |     23  |   56.3  | 15.12.2000 23:45:00  | [1; 23; 45; 23; 556]  | 
        1 :   "Jenny Lawrence"  |      2  |   56.3  | 15.12.2000 23:45:00  | [14; 63; 5; 8856]     | 
    *)

