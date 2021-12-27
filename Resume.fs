module Resume

open Feliz.ViewEngine

let intro = 
    Html.div [
        prop.classes [
            "text-5xl"
            "font-extrabold"
            "text-gray-200"
        ]
        prop.children [
            Html.h1 [
                prop.classes [
                    "border-b-4"
                    "mb-4"
                    "pb-4"
                ]
                prop.text "Sumeet Das"
            ]
        ]
    ]

type Experience = 
    {
        Title: string
        Duration: string
        Summary: string
        Highlights: ReactElement list
    }

let experienceList: Experience list = 
    let listElem (text: string) = 
        Html.li [
            prop.text text
        ]

    let concat (parts: string list) = parts |> String.concat " "

    [
        {
            Title = "sumeetdas.me"
            Duration = "24-Dec-2021 - 27-Dec-2021"
            Summary = "Rebuilt my website using F#"
            Highlights = [
                Html.ul [
                    prop.classes [
                        "list-disc"
                        "list-inside"
                    ]
                    prop.children (
                        [
                            "Rebuilt my personal website as a static"
                            "website using F#, Tailwind CSS and Vanilla JS"
                        ] |> concat |> listElem
                    )
                ]
            ]
        }
    ]

let experienceElem (experience: Experience) = 
    Html.div [
        prop.classes [
            "my-4"
        ]
        prop.children [
            Html.div [
                prop.children [
                    Html.b [
                        prop.classes [ "text-xl" ]
                        prop.text experience.Title
                    ]
                    Html.span [
                        prop.text (sprintf " - (%s)" experience.Duration)
                    ]
                ]
            ]
            Html.div [
                prop.children [
                    Html.b [
                        prop.text experience.Summary
                    ]
                ]
            ]
            Html.div experience.Highlights
        ]
    ]

let programmingExperience = 
    Html.div [
        prop.classes [
            "text-gray-200"
        ]
        prop.children ([
            Html.h2 [
                prop.classes [
                    "text-3xl"
                    "text-bold"
                    "border-b-2"
                    "pb-2"
                ]
                prop.text "Programming Experience"
            ]
        ] @ (experienceList |> List.map experienceElem))
    ]

let links = 
    let list: (string * string) list = 
        [
            "Website", "https://sumeetdas.me"
            "GitHub", "https://github.com/sumeetdas"
            "Twitter", "https://twitter.com/_sumeetdas"
            "LinkedIn", "https://in.linkedin.com/in/das-sumeet"
        ]

    let linkElem (link: string * string) = 
        let name, href = link
        Html.li [
            prop.classes []
            prop.children [
                Html.span [
                    prop.text (sprintf "%s - " name)
                ]
                Html.a [
                    prop.classes [
                        "border-b"
                    ]
                    prop.target "_blank"
                    prop.href href
                    prop.text href
                ]
            ]
        ]

    Html.div [
        prop.classes [
            "text-gray-200"
            "my-4"
        ]
        prop.children [
            Html.ul [
                prop.children ([
                    Html.h2 [
                        prop.classes [
                            "text-gray-200"
                            "text-3xl"
                            "text-bold"
                            "border-b-2"
                            "pb-2"
                        ]
                        prop.text "Links"
                    ]
                ] @ (list |> List.map linkElem))
            ]
        ]
    ]

let print = 
    Html.div [
        prop.classes [
            "flex"
            "flex-col"
            "mx-auto"
            "text-gray-200"
            "print:hidden"
        ]
        prop.children [
            Html.button [
                prop.classes [
                    "w-32"
                    "text-center"
                ]
                KeyValue ("onClick", "window.print()")
                prop.text "Print"
            ]
        ]
    ]

let resume =
    Html.div [
        prop.classes [
            "print:block"
        ]
        prop.id "resume"
        prop.children [
            intro
            programmingExperience
            links
        ]
    ]

let html = 
    [
        print 
        resume
    ]