module _Layout

open _Common
open Feliz.ViewEngine

let menu = 
    let items: (string * string) list = [
        "Home", ""
        "Resume", "/resume.html"
    ]

    let menuItem (item: string * string) = 
        let name, href = item
        Html.a [
            prop.classes [
                tw.``w-12``
                tw.``mx-2``
                tw.``flex``
                tw.``flex-col``
            ]
            prop.text name
            prop.href href
        ]

    Html.div [
        prop.classes [
            tw.``flex``
            tw.``flex-row``
            tw.``justify-center``
            tw.``align-middle``
        ]
        prop.children (items |> List.map menuItem)
    ]

let head = 
    Html.head [
        Html.link [
            prop.rel "stylesheet"
            prop.type' "text/css"
            prop.href "output.css"
        ]
    ]

let body (components: ReactElement list) = 
    let container = 
        Html.div [
            prop.classes [
                tw.``flex``
                tw.``flex-col``
                tw.``mx-auto``
                tw.``max-w-2xl``
                tw.``justify-center``
                tw.``align-middle``
                "h-full"
                "my-auto"
            ]
            prop.children components
        ]

    Html.body [
        prop.classes [
            "dark"
        ]
        prop.children [
            Html.div [
                prop.classes [
                    tw.``flex``
                    tw.``flex-col``
                    tw.``w-full``
                    "dark:bg-red-200"
                ]
                prop.children [ 
                    menu 
                    container
                ]
            ]
        ]
    ]

let layout (components: ReactElement list) = 
    Html.html [
        head   
        body components
    ]