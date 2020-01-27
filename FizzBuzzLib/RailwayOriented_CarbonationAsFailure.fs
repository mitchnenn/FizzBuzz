namespace FizzBuzzLib

module RailwayOriented_CarbonationAsFailure =
    
    open RailwayCombinatorModule
    
    let carbonate factor label i = 
        if i % factor = 0 then
            fail label
        else
            succeed i

    let fizzBuzz =
        carbonate 15 "FizzBuzz"
        >> bind (carbonate 3 "Fizz")
        >> bind (carbonate 5 "Buzz")
        >> either (printf "%i; ") (printf "%s; ")
