open Feliz.ViewEngine
open System.IO

let html =
    Html.h1 [
        prop.style [ style.fontSize(100); style.color("#137373") ]
        prop.text "Hello, world!"
    ]
    |> Render.htmlView

File.WriteAllBytes ("index.html", html |> System.Text.Encoding.ASCII.GetBytes)


// For more information see https://aka.ms/fsharp-console-apps

