module _Common

open Zanaptak.TypedCssClasses
open System.IO

type tw = CssClasses<"public/output.css">

let generateFile (fileName: string) (html: string) =
    File.WriteAllBytes (fileName, html |> System.Text.Encoding.ASCII.GetBytes)
