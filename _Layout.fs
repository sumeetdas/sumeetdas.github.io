module _Layout

open _Common
open Feliz.ViewEngine

let layout (components: ReactElement list) = 
    Html.div [
        prop.classes [
            tw.``flex``
        ]
        prop.children components
    ]