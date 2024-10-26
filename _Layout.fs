module _Layout

open _Common
open Feliz.ViewEngine

let menu (pageName: Page) = 
    let items: (string * string) list = [
        "Home", "/index.html"
        "Resume", "/resume.html"
    ]

    let menuItem (item: string * string) = 
        let name, href = item
        let isCurrentPage = href.Contains (pageName |> Page.fileName)
        Html.a [
            prop.classes ([
                tw.``w-24``
                tw.``mx-2``
                tw.``flex``
                tw.``flex-col``
                "text-gray-200"
                "text-2xl"
                "leading-8"
                "h-14"
                "lg:h-16"
                "text-center"
            ] @ (
                if isCurrentPage 
                then 
                    [
                        "border-b-4"
                        "font-extrabold"
                    ] 
                else []
                )
            )
            prop.text name
            prop.href href
        ]

    Html.div [
        prop.classes [
            tw.``flex``
            tw.``flex-row``
            tw.``justify-center``
            tw.``align-middle``
            "h-14"
            "lg:h-16"
            "my-4"
            "print:hidden"
        ]
        prop.children (items |> List.map menuItem)
    ]

let head (pageName: Page) = 
    Html.head [
        Html.title (pageName |> Page.title)
        Html.link [
            prop.rel "stylesheet"
            prop.type' "text/css"
            prop.href "style.css"
        ]
        Html.link [
            prop.rel "icon"
            prop.href "lambda.ico"
        ]
    ]

let body (pageName: Page) (components: Components) = 
    let containerClasses = [
        tw.``flex``
        tw.``flex-col``
        tw.``mx-auto``
        "max-w-md"
        "mt-4"
        tw.``md:max-w-md``
        tw.``lg:max-w-lg``
        tw.``xl:max-w-xl``
        tw.``2xl:max-w-2xl``
        tw.``justify-center``
        tw.``align-middle``
        "print:w-full"
        "print:max-w-xl"
    ]
    let container = 
        match components with
        | ReactElements elems -> 
            Html.div [
                prop.classes containerClasses
                prop.children elems
            ]
        | HtmlText text ->
            Html.div [
                prop.classes containerClasses
                prop.dangerouslySetInnerHTML text
            ]

    Html.body [
        prop.classes [
            "bg-slate-800"
        ]
        prop.children [
            Html.div [
                prop.classes [
                    tw.``flex``
                    tw.``flex-col``
                    tw.``w-full``
                    tw.``h-full``
                ]
                prop.children [ 
                    menu pageName
                    container
                ]
            ]
        ]
    ]

let layout (pageName: Page) (components: Components) = 
    Html.html [
        head pageName
        body pageName components
    ]

/// Converts a list of React elements to an HTML string
/// - pageName: The name of the page
/// - elems: The list of React elements
let htmlToString (pageName: Page) (elems: ReactElement list) = 
    ReactElements elems
    |> layout pageName
    |> Render.htmlView

let htmlTextToString (pageName: Page) (text: string) = 
    HtmlText text
    |> layout pageName
    |> Render.htmlView
