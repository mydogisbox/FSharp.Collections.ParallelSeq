(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
Tutorial
========================

Here is an example of using the parallel sequence combinators:
*)
#r "FSharp.Collections.ParallelSeq.dll"
open FSharp.Collections.ParallelSeq

let nums = [|1..500000|]
let finalDigitOfPrimes = 
        nums 
        |> PSeq.filter isPrime
        |> PSeq.groupBy (fun i -> i % 10)
        |> PSeq.map (fun (k, vs) -> (k, Seq.length vs))
        |> PSeq.toArray  
