// Issues
// * mutable tracking variable

namespace FizzBuzzLib

module IfPrime =
    
    let fizzBuzz i =
        let mutable printed = false
        
        if i % 3 = 0 then
            printed <- true
            printf "Fizz"
            
        if i % 5 = 0 then
            printed <- true
            printf "Buzz"
            
        if not printed then
            printf "%i" i
            
        printf "; "

