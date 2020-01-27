namespace FizzBuzzLib

module RailwayOriented_WithRules =
    
    open RailwayCombinatorModule
    
    let carbonate factor label i =
        if i % factor = 0 then
            carbonated label
        else
            uncarbonated i
    
    // something + something = combined something
    // zero + something = something
    // something + zero = something
    // zero + zero = zero
    // uncarbonated plays the role of "zero"
    let (<+>) switch1 switch2 x =
        match (switch1 x),(switch2 x) with
        | Carbonated s1,Carbonated s2 -> carbonated (s1 + s2)
        | Uncarbonated f1,Carbonated s2 -> carbonated s2
        | Carbonated s1,Uncarbonated f2 -> carbonated s1
        | Uncarbonated f1,Uncarbonated f2 -> uncarbonated f1
        
    let fizzBuzz rules =
        let carbonateAll =
            rules
            |> List.map (fun (factor,label) -> carbonate factor label)
            |> List.fold (<+>) uncarbonated
        
        carbonateAll
        >> either (printf "%i; ") (printf "%s; ")
    