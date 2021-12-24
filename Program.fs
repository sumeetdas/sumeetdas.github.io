open Feliz.ViewEngine

let html =
    Html.h1 [
        prop.style [ style.fontSize(100); style.color("#137373") ]
        prop.text "Hello, world!"
    ]
    |> Render.htmlView

printfn "Output: %s" html

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
