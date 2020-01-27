namespace FizzBuzzLib

module RailwayOriented_CarbonationIsSuccess =
    
    open RailwayCombinatorModule
    
    // Success track contains labels and
    // Failure track contains integers
    let carbonate factor label i =
        if i % factor = 0 then
            succeed label
        else
            fail i
        
    let connect f =
        either succeed f
 
    let fizzBuzz =
        carbonate 15 "FizzBuzz"
        >> connect (carbonate 3 "Fizz")
        >> connect (carbonate 5 "Buzz")
        >> either (printf "%s; ") (printf "%i; ")
 