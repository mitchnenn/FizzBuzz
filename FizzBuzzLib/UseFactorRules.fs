namespace FizzBuzzLib

module UseFactorRules =

    let fizzBuzz rules i =
        let mutable printed = false
        
        for factor,label in rules do
            if i % factor = 0 then
                printed <- true
                printf "%s" label
        
        if not printed then
            printf "%i" i
            
        printf "; "
