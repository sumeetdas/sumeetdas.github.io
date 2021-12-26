open _Common
open _Layout

Index.html |> htmlToString Page.Index |> generateFile "public/index.html"
Resume.html |> htmlToString Page.Resume |> generateFile "public/resume.html"