namespace FizzBuzzLib

module Pipeline_WithTuple =
    
    let carbonate factor label data =
        let (i,labelSoFar) = data
        if i % factor = 0 then
            let newLabel =
                labelSoFar
                |> Option.map (fun s -> s + label)
                // “bi-directional” piping
                |> defaultArg <| label 
            (i, Some newLabel)
        else
            data
        
    let labelOrDefault data =
        let (i,labelSoFar) = data
        labelSoFar
        // “bi-directional” piping
        |> defaultArg <| sprintf "%i" i
        
    let fizzBuzz i =
        (i,None)
        |> carbonate 3 "Fizz"
        |> carbonate 5 "Buzz"
        |> labelOrDefault
        |> printf "%s; "
