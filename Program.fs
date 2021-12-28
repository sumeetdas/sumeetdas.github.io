open _Common
open _Layout

Index.html |> htmlToString Page.Index |> generateFile "docs/index.html"
Resume.html |> htmlToString Page.Resume |> generateFile "docs/resume.html"