namespace FizzBuzzLib

module RailwayCombinatorModule =
    
    let(|Success|Failure|) =
        function
        | Choice1Of2 s -> Success s
        | Choice2Of2 f -> Failure f
        
    let succeed x = Choice1Of2 x
    let fail x = Choice2Of2 x
    
    let either successFunc failureFunc twoTrackInput =
        match twoTrackInput with
        | Success s -> successFunc s
        | Failure f -> failureFunc f
        
    let bind f =
        either f fail
        
    let (|Uncarbonated|Carbonated|) =
        function
        | Choice1Of2 u -> Uncarbonated u
        | Choice2Of2 c -> Carbonated c
        
    let uncarbonated x = Choice1Of2 x
    let carbonated x = Choice2Of2 x
 