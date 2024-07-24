// For more information see https://aka.ms/fsharp-console-apps
let sumMultiplesOf3 n =
    let rec helper current total =
        if current > n then
            total
        else
            helper (current + 3) (total + current)
    helper 3 0

let result = sumMultiplesOf3 27
printfn "The sum of all multiples of 3 up to 27 is %d" result




