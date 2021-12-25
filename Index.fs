module Index

open _Common
open _Layout
open Feliz.ViewEngine
open System.IO

let html =
    Html.div [
        prop.classes [
            tw.``flex``
            tw.``flex-col``
        ]
        prop.children [
            Html.img [
                prop.classes [ 
                    tw.``flex``
                    tw.``flex-col``
                    tw.``w-full``
                    tw.``h-auto``
                ]
                prop.src "myphoto.jpg" 
            ]
            Html.h1 [
                prop.classes [
                    "text-green-500"
                ]
                prop.text "Hello, world!!! Woof!!!"
            ]
        ]
    ]
    |> fun elem -> [ elem ]
    |> layout
    |> Render.htmlView

let generate() =
    File.WriteAllBytes ("public/index.html", html |> System.Text.Encoding.ASCII.GetBytes)
