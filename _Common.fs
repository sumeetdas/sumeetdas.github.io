module _Common

open Zanaptak.TypedCssClasses
open System.IO

type tw = CssClasses<"public/output.css">

let generateFile (fileName: string) (content: string) = 
    File.WriteAllBytes (fileName, content |> System.Text.Encoding.ASCII.GetBytes)
    // hack to make live-server detect file changes
    File.Create("public/temp.txt")