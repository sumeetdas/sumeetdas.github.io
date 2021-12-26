module Index

open _Common
open Feliz.ViewEngine

let private paraElem (text: string) = 
    Html.p [ 
        prop.classes [
            "dark:text-gray-200"
            "text-2xl"
            "my-3"
            "leading-8"
        ]
        prop.text text 
    ]

let private toPara (parts: string list) = 
    parts |> String.concat " " |> paraElem

let private aboutMe = 
    [
        [
            "I'm a software developer currently writing Java code for a living."
            "I love functional programming and writing code in F#."
            "My current interests are - F# / Rust / Distributed Systems / Developing"
            "Mobile and Web apps."
        ] |> toPara
        [
            "I currently live in India and I'm looking for"
            "fully remote jobs at the moment. I'm also open to"
            "relocating to other countries if need be."
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

let private links = 
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
            "my-4"
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
                    "text-black"
                    "dark:text-slate-200"
                    "text-4xl"
                    "text-center"
                    "my-3"
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

