namespace FizzBuzzLib

module Pipeline_With_Record =
    
    type Data = {i:int; label:string option}
    
    let carbonate factor label data =
        let  {i=i; label=labelSoFar} = data
        if i % factor = 0 then
            let newLabel =
                match labelSoFar with
                | Some s -> s + label
                | None -> label
            {data with label=Some newLabel}
        else
            data

    let labelOrDefault data =
        let {i=i; label=labelSoFar} = data
        match labelSoFar with
        | Some s -> s
        | None -> sprintf "%i" i
        
    let fizzBuzz i =
        {i=i; label=None}
        |> carbonate 3 "Fizz"
        |> carbonate 5 "Buzz"
        |> labelOrDefault
        |> printf "%s; "
    