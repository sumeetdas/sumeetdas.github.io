module _Common

open Zanaptak.TypedCssClasses
open System.IO
open Feliz.ViewEngine

type tw = CssClasses<"docs/style.css">

let generateFile (fileName: string) (html: string) =
    File.WriteAllBytes (fileName, html |> System.Text.Encoding.ASCII.GetBytes)

[<RequireQualifiedAccess>]
type Page =
    | Index 
    | Resume

type Components = 
    | ReactElements of ReactElement list
    | HtmlText of string

module Page = 
    let title (page: Page) = 
        match page with 
        | Page.Index -> "Sumeet Das"
        | Page.Resume -> "Resume"
    
    let fileName (page: Page) = 
        match page with 
        | Page.Index -> "index"
        | Page.Resume -> "resume"
