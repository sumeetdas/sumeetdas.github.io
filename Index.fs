module Index

open _Common
open Feliz.ViewEngine

let private paraClasses = 
    [
        "text-gray-200"
        "lg:text-2xl"
        "my-3"
        "leading-8"
        "px-6"
    ]

let private toParaWithStr (parts: string list) = 
    Html.p [
        prop.classes paraClasses
        prop.text (parts |> String.concat " ")
    ]

let private toParaWithElems (elems: ReactElement list) = 
    Html.p [
        prop.classes paraClasses
        prop.children elems
    ]

let private getLink (href: string, name: string) = 
    Html.a [
        prop.classes [
            "border-b-2"
        ]
        prop.target "_blank"
        prop.text name
        prop.href href
    ]

let private toText (parts: string list) = 
    Html.text (parts |> String.concat " ")

let private aboutMe = 
    [
        [
            [
                "I'm a software developer who writes Java code for a living."
                "I love functional programming and writing code in F#."
                "I have even developed this website "
            ] |> toText
            getLink ("https://github.com/sumeetdas/sumeetdas.github.io", "using F#")
            [
                ". My current interests are - F# / Rust / Distributed Systems / Developing"
                "Mobile and Web apps."
            ] |> toText
        ] |> toParaWithElems
        [
            "I live in India and I'm looking for"
            "fully remote jobs at the moment. I'm also open to"
            "relocating to other countries if need be."
        ] |> toParaWithStr
        [
            "You can follow me on GitHub and Twitter, or if you"
            "want to contact me, you can do so via Twitter DMs"
            "(Direct Message). I'm also available (but not active)"
            "on LinkedIn."
        ] |> toParaWithStr
    ]

let private links = 
    let list = [
        "icons/github.svg", "https://github.com/sumeetdas"
        "icons/twitter.svg", "https://twitter.com/_sumeetdas"
        "icons/linkedin.svg", "https://in.linkedin.com/in/das-sumeet"
    ]

    let elem (item: string * string) = 
        let icon, link = item
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
    [
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
                "text-slate-200"
                "text-5xl"
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

