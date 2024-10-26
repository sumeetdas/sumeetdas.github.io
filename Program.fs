open _Common
open _Layout
open QRCodeUtil

Index.html |> htmlToString Page.Index |> generateFile "docs/index.html"
Resume.html |> htmlTextToString Page.Resume |> generateFile "docs/resume.html"

// generateQRCode "https://sumeetdas.me/resume.html" "docs/qr.png" 
