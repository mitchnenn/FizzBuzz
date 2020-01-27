namespace FizzBuzzLib

module Pipeline_WithRules =
    
    let carbonate factor label data =
        let (i,labelSoFar) = data
        
        if i % factor = 0 then
            let newLabel =
                labelSoFar
                |> Option.map (fun s -> s + label)
                |> defaultArg <| label
            (i,Some newLabel)
        else
            data
            
    let labelOrDefault data =
        let (i,labelSoFar) = data
        labelSoFar
        |> defaultArg <| sprintf "%i" i
        
    let fizzBuzz rules i =
        
        let allRules =
            rules
            |> List.map (fun (factor,label) -> carbonate factor label)
            |> List.fold (>>) id
        
        (i,None)
        |> allRules
        |> labelOrDefault
        |> printf "%s; "
