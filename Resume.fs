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
                    "print:mb-2"
                    "print:pb-2"
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
                        "Implemented core features and improved performance"
                        "of Oracle Randomization Service (ORS) by optimizing"
                        "SQL queries"
                    ] |> concat |> listElem
                    [
                        "Worked on improving translatability of"
                        "the product across multiple microservices"
                    ] |> concat |> listElem
                    [
                        "Tech used: Kubernetes, Liquibase, Bash scripts,"
                        "Oracle DB, Java EE, git, OCI"
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
                        "Developed a dashboard to display various runtime statistics"
                    ] |> concat |> listElem
                    [
                        "Developed and maintained REST APIs, ran performance tests"
                        "using JMeter"
                    ] |> concat |> listElem
                    [
                        "Developed a module to create RFP Bid Grid - an"
                        "excel sheet created at runtime using Apache POI"
                    ] |> concat |> listElem
                    [
                        "Worked with teams based in the US and Australia"
                        "and using Scrum agile methodology"
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
            Duration = "March-2015 - August-2015"
            Summary = "Personal project on building blogging engine"
            Highlights = 
                [
                    [
                        "A blogging engine consisting of a REST API"
                        "for querying and modifying flat-file blogs"
                        "and a single page application (SPA) in the"
                        "front-end"
                    ] |> concat |> listElem
                    [
                        "Enables various search engine bots and"
                        "scrapers of social networking sites like"
                        "Facebook to retrieve several key metadata"
                        "from the blog whilst allowing developers"
                        "to use AngularJS in the front-end"
                    ] |> concat |> listElem
                    [
                        Html.text "Link: "
                        anchor (
                            "https://github.com/sumeetdas/Meow", 
                            "https://github.com/sumeetdas/Meow"
                        )
                    ] |> listElemHtml
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "AngularJS-JWT-OAuth2-Demo"
            Duration = "February-2015 - August-2015"
            Summary = "Personal project on authentication demo with Angular 1"
            Highlights = 
                [
                    [
                        "An app to demonstrate OAuth2 authentication and"
                        "front-end route authorization using JSON Web Token"
                        "(JWT) and Angular UI Router."
                    ] |> concat |> listElem
                    Html.li [
                        prop.children [
                            Html.text "Link - "
                            anchor (
                                "https://github.com/sumeetdas/AngularJS-JWT-OAuth2-Demo", 
                                "https://github.com/sumeetdas/AngularJS-JWT-OAuth2-Demo"
                            )
                        ]
                    ]
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "Sabre Holdings"
            Duration = "July-2012 - December-2012"
            Summary = "Internship - Built a project dashboard"
            Highlights = 
                [
                    [
                        "Developed Project Dashboard for GDS Ticketing"
                        "Team at Sabre Holdings, Bangalore"
                    ] |> concat |> listElem
                    [
                        "Web app capable of adding, updating and viewing"
                        "projects, retrieving budget data from Excel"
                        "spreadsheets maintained by Project Managers and"
                        "generating different types of reports in PDF"
                        "format on the fly"
                    ] |> concat |> listElem
                    [
                        "Powered by Yii, a PHP open-source MVC framework,"
                        "MySQL database, JQuery (a JavaScript library),"
                        "HTML5, CSS3 and various other open-source JavaScript"
                        "and PHP libraries"
                    ] |> concat |> listElem
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "Bhilai Steel Plant"
            Duration = "May 2011 - July 2011"
            Summary = "Summer Internship"
            Highlights = 
                [
                    [
                        "Developed SMS module for C & IT Department"
                    ] |> concat |> listElem
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
                Html.b [
                    prop.classes [ "text-xl" ]
                    prop.text education.Institution
                ]
                Html.span [
                    prop.text (sprintf " - %s" education.Duration)
                ]
            ]
            Html.b [
                prop.text education.Course
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
            "my-4"
            "print:hidden"
        ]
        prop.children [
            Html.button [
                prop.classes [
                    "w-20"
                    "text-center"
                    "text-xl"
                    "h-12"
                    "text-gray-100"
                    "text-white"
                    "border-2"
                    "border-sky-500"
                    "bg-sky-500"
                    "font-semibold"
                    "rounded"
                    "p-2"
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