module Index

open _Common
open _Layout
open Feliz.ViewEngine
open System.IO

let paraElem (text: string) = Html.p [ prop.text text ]

let toPara (parts: string list) = 
    parts |> String.concat " " |> paraElem

let aboutMe = 
    [
        [
            "I'm a software developer currently writing Java code for a living."
            "I love functional programming and writing code in F#."
            "My current interests are - Rust / F# / Distributed Systems / Developing"
            "Mobile and Web apps."
        ] |> toPara
        [
            "I currently live in India and I'm looking for"
            "fully remote jobs at the moment. I'm also open to"
            "relocate to other countries if need be."
        ] |> toPara
        [
            "You can follow me on GitHub and Twitter, or if you"
            "want to contact me, you can do so via Twitter DMs"
            "(Direct Message). I'm also available on LinkedIn"
            "but since I find the site quite depressing (more"
            "Insta-level posts and corporate cringe),"
            "I'm not very active there."
        ] |> toPara
    ]

let links = 
    let list = [
        "GitHub", "icons/github.svg", "https://github.com/sumeetdas"
        "Twitter", "icons/twitter.svg", "https://twitter.com/_sumeetdas"
        "LinkedIn", "icons/linkedin.svg", "https://in.linkedin.com/in/das-sumeet"
    ]

    let elem (item: string * string * string) = 
        let name, icon, link = item
        Html.a [
            prop.classes [
                "inline-flex"
                "mx-2"
                "bg-red-300"
                "text-white" 
                "p-4" 
                "rounded-full"
                "text-2xl" 
                "font-bold" 
                "overflow-visible"
                "w-16"
                "h-16"
            ]
            prop.href link
            prop.target "_blank"
            prop.children [
                Html.img [
                    prop.classes [
                        "align-middle"
                        "text-white"
                    ]
                    prop.src icon
                ]
            ]
        ]
    
    Html.div [
        prop.classes [
            "flex"
            "flex-row"
            "justify-center"
        ]
        prop.children (list |> List.map elem)
    ]

let html =
    Html.div [
        prop.classes [
            tw.``flex``
            tw.``flex-col``
            "my-auto"
        ]
        prop.children [
            Html.img [
                prop.classes [ 
                    tw.``flex``
                    tw.``flex-col``
                    tw.``w-48``
                    tw.``h-auto``
                    "mx-auto"
                ]
                prop.src "myphoto.jpg" 
            ]
            Html.h1 [
                prop.classes [
                    "text-green-500"
                ]
                prop.text "Sumeet Das"
            ]
            Html.div [
                prop.classes [
                    "flex"
                    "flex-col"
                    "my-auto"
                ]
                prop.children (aboutMe @ [ links ])
            ]
        ]
    ]
    |> fun elem -> [ elem ]
    |> layout
    |> Render.htmlView

let generate() =
    File.WriteAllBytes ("public/index.html", html |> System.Text.Encoding.ASCII.GetBytes)
