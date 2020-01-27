namespace FizzBuzzLib

module RailwayOriented_UsingCustomChoice =
    
    open RailwayCombinatorModule
    
    let carbonate factor label i =
        if i % factor = 0 then
            carbonated label
        else
            uncarbonated i
            
    let fizzBuzz =
        carbonate 15 "FizzBuzz"
        >> bind (carbonate 3 "Fizz")
        >> bind (carbonate 5 "Buzz")
        >> either (printf "%i; ") (printf "%s; ")
