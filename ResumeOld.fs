module ResumeOld

open Feliz.ViewEngine

let concat (parts: string list) = parts |> String.concat " "

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
            "text-4xl"
            "font-extrabold"
            "text-gray-200"
            "print:text-black"
        ]
        prop.children [
            Html.h1 [
                prop.classes [
                    "border-b-4"
                    "mb-4"
                    "pb-4"
                    "print:mb-3"
                    "print:pb-0"
                ]
                prop.text "Sumeet Das"
            ]
            Html.p [
                prop.classes [
                    // "text-lg"
                    // "mt-4"
                    // "text-gray-400"
                    // "print:text-black"
                    "text-sm" 
                    "mt-4"
                    "text-white"  // White text for better contrast
                    "font-light"  // Light weight for a subtle look
                    "leading-relaxed"  // Spacing for better readability
                    "print:text-black" // Black text for print
                    "print:text-sm" 
                    "print:font-normal"
                    "print:leading-snug"
                ]   
                [
                    "Experienced Software Engineer with over 11 years of expertise in "
                    "full-stack development, cloud infrastructure, and DevOps. Proficient in "
                    "Java, AWS, and Terraform, with a focus on designing scalable, "
                    "high-performance systems. Passionate about driving innovation through "
                    "automation and modern tech stacks to deliver robust solutions."
                ] |> concat |> prop.text
            ]
        ]
    ]


// Summary:


// Skills:
// Languages:

//     Java, Python, JavaScript, SQL, F#

// Cloud & DevOps:

//     AWS (EC2, S3, Lambda, Step Functions), Azure (Azure Data Factory), Docker, Kubernetes, Terraform

// Frameworks:

//     Spring Boot, Node.js, React.js, Angular, Flask

// Databases:

//     PostgreSQL, AzureSQL, Oracle DB

// Tools:

//     Git, Jenkins, JIRA, Confluence


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

let workExperienceList: Experience list = 
    let listElem (text: string) = 
        Html.li [
            prop.text text
        ]
    
    let listElemHtml (children: ReactElement list) = 
        Html.li [
            prop.children children
        ]

    [
        {
            Title = "Delphix (acquired by Perforce) - Remote"
            Duration = "May-2024 - Present"
            Summary = "Worked on DCS for Azure product"
            Highlights = 
                [
                    [
                        "Collaborated with the team in the US "
                        "to get onboarded to the product"
                    ] |> concat |> listElem
                    [
                        "Contributed to the General Availability (GA) release of the Discovery service, "
                        "which profiles data and recommends suitable masking algorithms."
                    ] |> concat |> listElem
                    [
                        "Worked on various Azure Data Factory templates that allow "
                        "profiling and masking of various data sources such as Snowflake and Azure SQL."
                    ] |> concat |> listElem
                    [
                        "Tech used: Azure (ADF, AppConfig, AzureSQL, AKS), "
                        "Java (Spring Boot, Mockito)"
                    ] |> concat |> listElem
                    [
                        Html.text "Product URL - "
                        anchor (
                            "https://www.delphix.com/solutions/microsoft", 
                            "https://www.delphix.com/solutions/microsoft"
                        )
                    ] |> listElemHtml
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "Delphix (acquired by Perforce) - Remote"
            Duration = "November-2022 - April-2024"
            Summary = "Worked on DCS for Salesforce product"
            Highlights = 
                [
                    [
                        "Helped establish the newly formed India team "
                        "focused on DCS for Salesforce."
                    ] |> concat |> listElem
                    [
                        "Developed new features such as masking report "
                        "and enhanced parity with Delphix's Continuous Compliance product."
                    ] |> concat |> listElem
                    [
                        "Developed in-depth knowledge of Salesforce architecture, "
                        "including metadata, data APIs, and SOQL queries."
                    ] |> concat |> listElem
                    [
                        "Facilitated the onboarding of a new customer by resolving product "
                        "issues and providing dedicated support."
                    ] |> concat |> listElem
                    [
                        "Strengthened the India team by interviewing "
                        "and onboarding new members."
                    ] |> concat |> listElem
                    [
                        "Tech used: AWS (Cloudwatch, SQS, SNS, S3, Step Functions, Lambda, Batch Jobs), "
                        "Python (Flask, Pytest), Terraform, Java, Angular, GraphQL"
                    ] |> concat |> listElem
                    [
                        Html.text "Product URL - "
                        anchor (
                            "https://www.delphix.com/video/automated-masking-salesforce-sandboxes", 
                            "https://www.delphix.com/video/automated-masking-salesforce-sandboxes"
                        )
                    ] |> listElemHtml
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "Oracle India Pvt. Ltd. - Hyderabad, India"
            Duration = "April-2018 - October-2022"
            Summary = "Working on ClinicalOne product"
            Highlights = 
                [
                    [
                        "Implemented core features in Oracle"
                        "Randomization Service (ORS)"
                    ] |> concat |> listElem
                    [
                        "Brought down API response times to SLA"
                        "by optimizing SQL queries"
                    ] |> concat |> listElem
                    [
                        "Worked on improving translatability of"
                        "the product across multiple microservices"
                    ] |> concat |> listElem
                    [
                        "Mentored interns and part of interview panel"
                        "to recruit new employees"
                    ] |> concat |> listElem
                    [
                        "Tech used: Kubernetes, Liquibase, Bash scripts,"
                        "Oracle DB, Java EE, git, OCI, GraphQL, Kafka, Zookeeper"
                    ] |> concat |> listElem
                    [
                        Html.text "Product URL - "
                        anchor ("https://www.oracle.com/industries/life-sciences/clinical-one/", "https://www.oracle.com/industries/life-sciences/clinical-one/")
                    ] |> listElemHtml
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "Oracle India Pvt. Ltd. - Remote"
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
            Title = "Sabre Holdings - Bangalore, India"
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
            Title = "Bhilai Steel Plant - Bhilai, India"
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

let personalProjectsList: Experience list = 
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
            Title = "Bleeter"
            Duration = "Oct-2021 - Dec-2021"
            Summary = "UI for GTA V's Twitter parody built using F#"
            Highlights = 
                [
                    [
                        "Built UI for GTA V's microblogging site Bleeter"
                        "using F# (transpiled into JS via Fable compiler)"
                        ", Tailwind CSS and React"
                    ] |> concat |> listElem
                    [
                        "This app follows Elm architecture (also known as"
                        "Model-View-Update [MVU])"
                    ] |> concat |> listElem
                    Html.li [
                        prop.children [
                            Html.text "URL - "
                            anchor ("https://sumeetdas.me/Bleeter", "https://sumeetdas.me/Bleeter")
                        ]
                    ]
                ] |> unorderedList |> fun elem -> [ elem ]
        }
        {
            Title = "sumeetdas.me"
            Duration = "24-Dec-2021 - 29-Dec-2021"
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
    ]

let experienceElem (experience: Experience) = 
    Html.div [
        prop.classes ([ "my-4"; "print:my-2" ] @ (
            if experience.Title.Contains "xyz" 
            then [ "break-before-page" ] else []))
        prop.children [
            Html.div [
                prop.children [
                    Html.b [
                        prop.classes [ "text-lg" ]
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

let workExperience = 
    Html.div [
        prop.classes [
            "text-gray-200"
            "print:text-black"
        ]
        prop.children ([
            Html.h2 [
                prop.classes [
                    "text-2xl"
                    "text-bold"
                    "border-b-2"
                    "pb-2"
                    "print:pb-0"
                    "print:mb-3"
                ]
                prop.text "Work Experience"
            ]
        ] @ (workExperienceList |> List.map experienceElem))
    ]

let personalProjects = 
    Html.div [
        prop.classes [
            "text-gray-200"
            "print:text-black"
        ]
        prop.children ([
            Html.h2 [
                prop.classes [
                    "text-2xl"
                    "text-bold"
                    "border-b-2"
                    "pb-2"
                    "print:pb-0"
                    "print:mb-3"
                ]
                prop.text "Personal Projects"
            ]
        ] @ (personalProjectsList |> List.map experienceElem))
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
                // [
                //     "Electives completed: Fuzzy Logic, Image Processing,"
                //     "Effective Public Speaking, Object Oriented"
                //     "Programming, International Relations"
                // ] |> String.concat " " |> listItem
            ]
        }
    ]

let educationElem (education: Education) = 
    Html.div [
        prop.classes [ "my-4"; "print:my-2" ]
        prop.children [
            Html.div [
                Html.b [
                    prop.classes [ "text-lg" ]
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
            "print:text-black"
        ]
        prop.children ([
            Html.h2 [
                prop.classes [
                    "text-2xl"
                    "text-bold"
                    "border-b-2"
                    "pb-2"
                    "print:pb-0"
                    "print:my-3"
                    // "break-before-page"
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
                "my-4"
                "sm:my-2"
                "print:my-0"
            ]
            prop.children [
                Html.span [
                    prop.text (sprintf "%s - " name)
                ]
                anchor (href, href)
            ]
        ]

    Html.div [
        prop.classes [ "text-gray-200"; "print:text-black" ]
        prop.children [
            Html.ul [
                prop.children ([
                    Html.h2 [
                        prop.classes [
                            "text-gray-200"
                            "print:text-black"
                            "text-2xl"
                            "text-bold"
                            "border-b-2"
                            "pb-2"
                            "print:mb-3"
                            "print:pb-0"
                        ]
                        prop.text "Links"
                    ]
                ] @ (list |> List.map linkElem))
            ]
        ]
    ]

let print = 
    let buttonClasses = 
        [
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
            "mx-2"
        ]

    Html.div [
        prop.classes [
            "flex"
            "flex-row"
            "mx-auto"
            "text-gray-200"
            "print:text-black"
            "my-4"
            "print:hidden"
        ]
        prop.children [
            Html.a [
                prop.target "_blank"
                prop.children [
                    Html.button [
                        prop.classes buttonClasses
                        prop.text "Save"
                    ]
                ]
                prop.href "Sumeet_Das_Resume.pdf"
            ]
        ]
    ]

let resume =
    Html.div [
        prop.classes [
            "print:block"
            "print:-mt-4"
        ]
        prop.id "resume"
        prop.children [
            intro
            workExperience
            personalProjects
            education
            links
            Html.span [
                prop.classes [ "css-print-hack" ]
                prop.text " "
            ]
            Html.b [
                prop.classes [ "css-print-hack" ]
                prop.text " "
            ]
        ]
    ]

let html = 
    [
        print 
        resume
    ]