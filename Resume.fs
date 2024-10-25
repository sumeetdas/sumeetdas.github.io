module Resume

open Scriban

let concat (parts: string list) = parts |> String.concat " "

// Define your complex types
type Experience = {
    Company: string
    Designation: string
    Duration: string
    Location: string
    Summary: string
    Highlights: string list
    ProductUrl: string option
}

type PersonalProject = {
    Name: string
    Highlights: string list
    Duration: string
    Summary: string
    ProjectUrl: string
}

type Education = 
    {
        Institution: string
        Course: string
        Duration: string
        Highlights: string list
    }

type Skills = {
    Category: string
    Items: string list
}

let NAME: string = "Sumeet Das"
let SUMMARY: string = 
    [
        "Experienced Software Engineer with over 11 years of expertise in "
        "full-stack development, cloud infrastructure, and DevOps. Proficient in "
        "Java, AWS, and Terraform, with a focus on designing scalable, "
        "high-performance systems. Passionate about driving innovation through "
        "automation and modern tech stacks to deliver robust solutions."
    ] |> concat

let GITHUB: string = "https://github.com/sumeetdas"

let LINKEDIN: string = "https://in.linkedin.com/in/das-sumeet"

let EMAIL: string = "sumeetdasinterview@gmail.com"

let X: string = "https://x.com/_sumeetdas"

let skills: Skills list = [
    {
        Category = "Languages"
        Items = ["Java"; "Python"; "F#"; "TypeScript"; "SQL"; "Bash"]
    }
    {
        Category = "Frameworks"
        Items = ["Spring Boot"; "Flask"; "Angular"; "NodeJS"; "React"; "Tailwind CSS"]
    }
    {
        Category = "Cloud"
        Items = [
            "AWS (EC2, S3, Lambda, Step Functions)"
            "Azure (Azure Data Factory)"
            "Kubernetes"; "Docker"; "Terraform"
        ]
    }
    {
        Category = "Databases"
        Items = ["AzureSQL"; "PostgreSQL"; "SQLite"; "Oracle"; "Redis"]
    }
    {
        Category = "Tools"
        Items = ["Git"; "Jenkins"; "Jira"; "Confluence"; "Docker"]
    }
]

let workExperiences: Experience list = [
    {
        Company = "Delphix (acquired by Perforce)"
        Location = "Remote"
        Designation = "Senior Software Development Engineer III"
        Duration = "May-2024 - Present"
        Summary = "Worked on DCS for Azure product"
        Highlights = [
            [
                "Collaborated with the team in the US "
                "to get onboarded to the product"
            ] |> concat
            [
                "Contributed to the General Availability (GA) release of the Discovery service, "
                "which profiles data and recommends suitable masking algorithms."
            ] |> concat
            [
                "Worked on various Azure Data Factory templates that allow "
                "profiling and masking of various data sources such as Snowflake and Azure SQL."
            ] |> concat
            [
                "Tech used: Azure (ADF, AppConfig, AzureSQL, AKS), "
                "Java (Spring Boot, Mockito)"
            ] |> concat
        ]
        ProductUrl = Some "https://www.delphix.com/solutions/microsoft"
    }
    {
        Company = "Delphix (acquired by Perforce)"
        Location = "Remote"
        Designation = "Senior Software Development Engineer III"
        Duration = "November-2022 - April-2024"
        Summary = "Worked on DCS for Salesforce product"
        Highlights = [
            [
                "Helped establish the newly formed India team "
                "focused on DCS for Salesforce."
            ] |> concat
            [
                "Developed new features such as masking report "
                "and enhanced parity with Delphix's Continuous Compliance product."
            ] |> concat
            [
                "Developed in-depth knowledge of Salesforce architecture, "
                "including metadata, data APIs, and SOQL queries."
            ] |> concat
            [
                "Facilitated the onboarding of a new customer by resolving product "
                "issues and providing dedicated support."
            ] |> concat
            [
                "Strengthened the India team by interviewing "
                "and onboarding new members."
            ] |> concat
            [
                "Tech used: AWS (Cloudwatch, SQS, SNS, S3, Step Functions, Lambda, Batch Jobs), "
                "Python (Flask, Pytest), Terraform, Java, Angular, GraphQL"
            ] |> concat
        ] 
        ProductUrl = Some "https://www.delphix.com/video/automated-masking-salesforce-sandboxes"
    }
    {
        Company = "Oracle India Pvt. Ltd."
        Location = "Hyderabad, India"
        Designation = "Senior Software Engineer"
        Duration = "April-2018 - October-2022"
        Summary = "Worked on ClinicalOne product"
        Highlights = [
            [
                "Implemented core features in Oracle "
                "Randomization Service (ORS)"
            ] |> concat
            [
                "Brought down API response times to SLA "
                "by optimizing SQL queries"
            ] |> concat
            [
                "Worked on improving translatability of "
                "the product across multiple microservices"
            ] |> concat
            [
                "Mentored interns and was part of the interview panel "
                "to recruit new employees"
            ] |> concat
            [
                "Tech used: Kubernetes, Liquibase, Bash scripts, "
                "Oracle DB, Java EE, git, OCI, GraphQL, Kafka, Zookeeper"
            ] |> concat
        ]
        ProductUrl = Some "https://www.oracle.com/in/life-sciences/clinical-trials/"
    }
    {
        Company = "Oracle India Pvt. Ltd."
        Location = "Remote"
        Designation = "Software Engineer"
        Duration = "July-2013 - March-2018"
        Summary = "Worked on ClearTrial product"
        Highlights = [
            [
                "Developed a dashboard to display various runtime statistics"
            ] |> concat
            [
                "Developed and maintained REST APIs, ran performance tests "
                "using JMeter"
            ] |> concat
            [
                "Developed a module to create RFP Bid Grid - an "
                "excel sheet created at runtime using Apache POI"
            ] |> concat
            [
                "Worked with teams based in the US and Australia "
                "using Scrum agile methodology"
            ] |> concat
        ]
        ProductUrl = Some "https://www.oracle.com/in/life-sciences/clinical-trials/cleartrial-portfolio-planning/"
    }
    {
        Company = "Sabre Holdings"
        Location = "Bangalore, India"
        Designation = "Software Developer Intern"
        Duration = "July-2012 - December-2012"
        Summary = "Internship - Built a project dashboard"
        Highlights = [
            [
                "Developed Project Dashboard for GDS Ticketing"
                "Team at Sabre Holdings, Bangalore"
            ] |> concat
            [
                "Web app capable of adding, updating and viewing"
                "projects, retrieving budget data from Excel"
                "spreadsheets maintained by Project Managers and"
                "generating different types of reports in PDF"
                "format on the fly"
            ] |> concat
            [
                "Powered by Yii, a PHP open-source MVC framework,"
                "MySQL database, JQuery (a JavaScript library),"
                "HTML5, CSS3 and various other open-source JavaScript"
                "and PHP libraries"
            ] |> concat
        ]
        ProductUrl = None 
    }
    {
        Company = "Bhilai Steel Plant"
        Location = "Bhilai, India"
        Designation = "Summer Intern"
        Duration = "May 2011 - July 2011"
        Summary = "Summer Internship"
        Highlights = [
            "Developed SMS module for C & IT Department"
        ]
        ProductUrl = None
    }
]

let personalProjectsList: PersonalProject list = 
    [
        {
            Name = "Bleeter"
            Duration = "Oct-2021 - Dec-2021"
            Summary = "UI for GTA V's Twitter parody built using F#"
            ProjectUrl = "https://sumeetdas.me/Bleeter"
            Highlights = [
                [
                    "Built UI for GTA V's microblogging site Bleeter"
                    "using F# (transpiled into JS via Fable compiler)"
                    ", Tailwind CSS and React"
                ] |> concat
                [
                    "This app follows Elm architecture (also known as"
                    "Model-View-Update [MVU])"
                ] |> concat
            ]
        }
        {
            Name = "sumeetdas.me"
            Duration = "24-Dec-2021 - 29-Dec-2021"
            Summary = "Rebuilt my website using F#"
            ProjectUrl = "https://sumeetdas.me"
            Highlights = [
                [
                    "Rebuilt my personal website as a static"
                    "website using F#, Tailwind CSS and Vanilla JS"
                ] |> concat
            ]
        }
        {
            Name = "Meow Blogging Engine"
            Duration = "March-2015 - August-2015"
            Summary = "Personal project on building blogging engine"
            ProjectUrl = "https://github.com/sumeetdas/Meow"
            Highlights = [
                [
                    "A blogging engine consisting of a REST API"
                    "for querying and modifying flat-file blogs"
                    "and a single page application (SPA) in the"
                    "front-end"
                ] |> concat 
                [
                    "Enables various search engine bots and"
                    "scrapers of social networking sites like"
                    "Facebook to retrieve several key metadata"
                    "from the blog whilst allowing developers"
                    "to use AngularJS in the front-end"
                ] |> concat
            ] 
        }
        {
            Name = "AngularJS-JWT-OAuth2-Demo"
            Duration = "February-2015 - August-2015"
            Summary = "Personal project on authentication demo with Angular 1"
            ProjectUrl = "https://github.com/sumeetdas/AngularJS-JWT-OAuth2-Demo"
            Highlights = [
                [
                    "An app to demonstrate OAuth2 authentication and"
                    "front-end route authorization using JSON Web Token"
                    "(JWT) and Angular UI Router."
                ] |> concat
            ]
        }
    ]

let educationList: Education list = 
    [
        {
            Institution = "BITS Pilani - Pilani Campus"
            Course = "B.E. (Hons.) Electronics and Instrumentation"
            Duration = "Aug 2009 - June 2013"
            Highlights = [
                "Graduated with First Class Honors and a GPA of 7.61"
                // [
                //     "Electives completed: Fuzzy Logic, Image Processing,"
                //     "Effective Public Speaking, Object Oriented"
                //     "Programming, International Relations"
                // ] |> String.concat " " |> listItem
            ]
        }
    ]


// Data binding using anonymous records
let data = {| 
    name = NAME
    github = GITHUB
    linkedin = LINKEDIN
    email = EMAIL
    x = X
    summary = SUMMARY
    skills = skills
    experiences = workExperiences 
    personalProjects = personalProjectsList
    education = educationList
|}

// Load the template from 'template.html' file
open System.IO
let templateString = File.ReadAllText("template.html")

// Compile and render the template
let template = Template.Parse(templateString)
let result = template.Render(data)

printfn "%s" result
