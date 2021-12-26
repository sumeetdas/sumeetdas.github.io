open _Common
open _Layout

Index.html |> htmlToString |> generateFile "public/index.html"
Resume.html |> htmlToString |> generateFile "public/resume.html"