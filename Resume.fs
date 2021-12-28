module Resume

open Feliz.ViewEngine

let anchor (name: string, href: string) = 
    Html.a [
        prop.classes [
            "border-b"
        ]
        prop.target "_blank"
        prop.text name
        prop.href href
    ]

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

let unorderedList (listItems: ReactElement list) = 
    Html.ul [
        prop.classes [
            "list-disc"
            "list-inside"
        ]
        prop.children listItems
    ]

let experienceList: Experience list = 
    let listElem (text: string) = 
        Html.li [
            prop.text text
        ]
    
    let listElemHtml (children: ReactElement list) = 
        Html.li [
            prop.children children
        ]

    let concat (parts: string list) = parts |> String.concat " "

    [
        {
            Title = "sumeetdas.me"
            Duration = "24-Dec-2021 - 27-Dec-2021"
            Summary = "Rebuilt my website using F#"
            Highlights = 
                [
                    [
                        "Rebuilt my personal website as a static"
                        "website using F#, Tailwind CSS and Vanilla JS"
                    ] |> concat |> listElem
                    Html.li [
                        prop.children [
                            Html.text "URL - "
                            anchor ("https://sumeetdas.me", "https://sumeetdas.me")
                        ]
                    ]
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "Oracle India Pvt. Ltd."
            Duration = "April-2018 - Present"
            Summary = "Working on ClinicalOne product"
            Highlights = 
                [
                    [
                        "Rebuilt my personal website as a static"
                        "website using F#, Tailwind CSS and Vanilla JS"
                    ] |> concat |> listElem
                    [
                        "Involved in improving translatability of"
                        "the application"
                    ] |> concat |> listElem
                    [
                        Html.text "Product URL - "
                        anchor ("https://www.oracle.com/industries/life-sciences/clinical-one/", "https://www.oracle.com/industries/life-sciences/clinical-one/")
                    ] |> listElemHtml
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "Oracle India Pvt. Ltd."
            Duration = "July-2013 - March-2018"
            Summary = "Worked on ClearTrial product"
            Highlights = 
                [
                    [
                        "Rebuilt my personal website as a static"
                        "website using F#, Tailwind CSS and Vanilla JS"
                    ] |> concat |> listElem
                    Html.li [
                        prop.children [
                            Html.text "Product URL - "
                            anchor (
                                "https://www.oracle.com/in/industries/life-sciences/cleartrial-portfolio-planning.html", 
                                "https://www.oracle.com/in/industries/life-sciences/cleartrial-portfolio-planning.html"
                            )
                        ]
                    ]
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "Meow Blogging Engine"
            Duration = "2015"
            Summary = "Personal project on building blogging engine"
            Highlights = 
                [
                    [
                        "Rebuilt my personal website as a static"
                        "website using F#, Tailwind CSS and Vanilla JS"
                    ] |> concat |> listElem
                    [
                        "Project is now archived. Links: " |> listElem
                        [
                            "Meow: The core blogging engine" |> listElem
                            [
                                [
                                    Html.text "Link: "
                                    anchor (
                                        "https://github.com/sumeetdas/Meow", 
                                        "https://github.com/sumeetdas/Meow"
                                    )
                                ] |> listElemHtml
                            ] |> unorderedList
                        ] |> unorderedList
                    ] |> unorderedList
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "sumeetdas.me"
            Duration = "24-Dec-2021 - 27-Dec-2021"
            Summary = "Rebuilt my website using F#"
            Highlights = 
                [
                    [
                        "Rebuilt my personal website as a static"
                        "website using F#, Tailwind CSS and Vanilla JS"
                    ] |> concat |> listElem
                    Html.li [
                        prop.children [
                            Html.text "URL - "
                            anchor ("https://sumeetdas.me", "https://sumeetdas.me")
                        ]
                    ]
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "sumeetdas.me"
            Duration = "24-Dec-2021 - 27-Dec-2021"
            Summary = "Rebuilt my website using F#"
            Highlights = 
                [
                    [
                        "Rebuilt my personal website as a static"
                        "website using F#, Tailwind CSS and Vanilla JS"
                    ] |> concat |> listElem
                    Html.li [
                        prop.children [
                            Html.text "URL - "
                            anchor ("https://sumeetdas.me", "https://sumeetdas.me")
                        ]
                    ]
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "sumeetdas.me"
            Duration = "24-Dec-2021 - 27-Dec-2021"
            Summary = "Rebuilt my website using F#"
            Highlights = 
                [
                    [
                        "Rebuilt my personal website as a static"
                        "website using F#, Tailwind CSS and Vanilla JS"
                    ] |> concat |> listElem
                    Html.li [
                        prop.children [
                            Html.text "URL - "
                            anchor ("https://sumeetdas.me", "https://sumeetdas.me")
                        ]
                    ]
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "sumeetdas.me"
            Duration = "24-Dec-2021 - 27-Dec-2021"
            Summary = "Rebuilt my website using F#"
            Highlights = 
                [
                    [
                        "Rebuilt my personal website as a static"
                        "website using F#, Tailwind CSS and Vanilla JS"
                    ] |> concat |> listElem
                    Html.li [
                        prop.children [
                            Html.text "URL - "
                            anchor ("https://sumeetdas.me", "https://sumeetdas.me")
                        ]
                    ]
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "sumeetdas.me"
            Duration = "24-Dec-2021 - 27-Dec-2021"
            Summary = "Rebuilt my website using F#"
            Highlights = 
                [
                    [
                        "Rebuilt my personal website as a static"
                        "website using F#, Tailwind CSS and Vanilla JS"
                    ] |> concat |> listElem
                    Html.li [
                        prop.children [
                            Html.text "URL - "
                            anchor ("https://sumeetdas.me", "https://sumeetdas.me")
                        ]
                    ]
                ] |> unorderedList |> fun elem -> [ elem ]
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

type Education = 
    {
        Institution: string
        Course: string
        Duration: string
        Highlights: ReactElement list
    }

let educationList: Education list = 
    let listItem (text: string) = 
        Html.li [
            prop.classes [ 
                "my-1"
            ]
            prop.text text
        ]

    [
        {
            Institution = "BITS Pilani - Pilani Campus"
            Course = "B.E. (Hons.) Electronics and Instrumentation"
            Duration = "Aug 2009 - June 2013"
            Highlights = [
                listItem "Graduated with First Class Honors and a GPA of 7.61"
                [
                    "Electives completed: Fuzzy Logic, Image Processing,"
                    "Effective Public Speaking, Object Oriented"
                    "Programming, International Relations"
                ] |> String.concat " " |> listItem
            ]
        }
    ]

let educationElem (education: Education) = 
    Html.div [
        prop.children [
            Html.div [
                prop.text education.Institution
            ]
            Html.div [
                prop.text education.Course
            ]
            Html.div [
                prop.text education.Duration
            ]
            Html.div [
                education.Highlights |> unorderedList
            ]
        ]
    ]

let education =
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
                prop.text "Education"
            ]
        ] @ (educationList |> List.map educationElem))
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
            prop.classes [
                "my-1"
            ]
            prop.children [
                Html.span [
                    prop.text (sprintf "%s - " name)
                ]
                anchor (href, href)
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
            education
            links
        ]
    ]

let html = 
    [
        print 
        resume
    ]