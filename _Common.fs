module _Common

open Zanaptak.TypedCssClasses
open System.IO

type tw = CssClasses<"public/style.css">

let generateFile (fileName: string) (html: string) =
    File.WriteAllBytes (fileName, html |> System.Text.Encoding.ASCII.GetBytes)

[<RequireQualifiedAccess>]
type Page =
    | Index 
    | Resume

module Page = 
    let title (page: Page) = 
        match page with 
        | Page.Index -> "Sumeet Das"
        | Page.Resume -> "Resume"
    
    let fileName (page: Page) = 
        match page with 
        | Page.Index -> "index"
        | Page.Resume -> "resume"
