/// https://fsharpforfunandprofit.com/posts/railway-oriented-programming-carbonated/
/// Write a program that prints the numbers from 1 to 100. 
/// * For multiples of three print "Fizz" instead of the number.
/// * For multiples of five print "Buzz". 
/// * For numbers which are multiples of both three and five print "FizzBuzz".

open FizzBuzLib
open FizzBuzzLib

[<EntryPoint>]
let main argv =
    printfn "FizzBuzz:Match 1 - 100"
    [1..100] |> List.iter Match.fizzBuzz
    printfn "\n"
    
    printfn "FizzBuzz:IfPrime 1 - 100"
    [1..100] |> List.iter IfPrime.fizzBuzz
    printfn "\n"
    
    printfn "FizzBuzz:UseFactorRules 1 - 100"
    let useFactorRules = [ (3,"Fizz"); (5, "Buzz") ]
    [1..100] |> List.iter (UseFactorRules.fizzBuzz useFactorRules) 
    printfn "\n"
    let useFactorRules = [ (3,"Fizz"); (5, "Buzz"); (7,"Baz") ]
    [1..100] |> List.iter (UseFactorRules.fizzBuzz useFactorRules) 
    printfn "\n"
    
    printfn "FizzBuzz:Pipeline_With_Record 1 - 100"
    [1..100] |> List.iter Pipeline_With_Record.fizzBuzz
    printfn "\n"
    
    printfn "FizzBuzz:Pipeline_WithTuple 1 - 100"
    [1..100] |> List.iter Pipeline_WithTuple.fizzBuzz
    printfn "\n"

    printfn "FizzBuzz:Pipeline_WithRules 1 - 100"
    let pipelineWithRules = [ (3, "Fizz"); (5, "Buzz") ]
    [1..100] |> List.iter (Pipeline_WithRules.fizzBuzz pipelineWithRules)
    let emptyRules = []
    [1..100] |> List.iter (Pipeline_WithRules.fizzBuzz emptyRules)
    printfn "\n"

    printfn "FizzBuzz:RailwayOriented_CarbonationIsSuccess"
    [1..100] |> List.iter RailwayOriented_CarbonationIsSuccess.fizzBuzz
    printfn "\n"
            
    printfn "FizzBuzz:RailwayOriented_CarbonationAsFailure"
    [1..100] |> List.iter RailwayOriented_CarbonationAsFailure.fizzBuzz
    printfn "\n"

    printfn "FizzBuzz:RailwayOriented_UsingCustomChoice"
    [1..100] |> List.iter RailwayOriented_UsingCustomChoice.fizzBuzz
    printfn "\n"

    printfn "FizzBuzz:RailwayOriented_WithRules"
    let railwayRules = [ (3, "Fizz"); (5, "Buzz"); (7, "Baz") ]
    [1..105] |> List.iter (RailwayOriented_WithRules.fizzBuzz emptyRules)
    [1..105] |> List.iter (RailwayOriented_WithRules.fizzBuzz railwayRules)
    printfn "\n"

    0 // return an integer exit code
