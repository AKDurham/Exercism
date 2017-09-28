module Bob

let isUpper (input: string): bool =
    input.ToUpper() = input && input.ToLower() <> input

let isQuestion (input: string): bool =
    input.EndsWith("?")

let isExclamation (input: string): bool =
    input.EndsWith("!")

let isYelling (input: string): bool =
    isUpper(input) || isExclamation(input)

let hey (input: string): string = 
    match input with
    | input when (input.Trim() = "") -> "Fine. Be that way!"
    | input when (isYelling(input)) -> "Whoa, chill out!"
    | input when (isQuestion(input)) -> "Sure."
    | _ -> "Whatever."