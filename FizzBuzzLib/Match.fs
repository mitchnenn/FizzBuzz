// Issues:
// * Special case for 15.
// * Adding cases requires code change, and moe special cases.
// * Order of matching is important.
//     - Largest cases numbers need to go first

namespace FizzBuzLib

module Match =
    let fizzBuzz i =
        match i with
        | _ when i % 15 = 0 ->
            printf "FizzBuzz"
        | _ when i % 3 = 0 ->
            printf "Fizz"
        | _ when i % 5 = 0 ->
            printf "Buzz"
        | _ ->
            printf "%i" i
        
        printf"; "
