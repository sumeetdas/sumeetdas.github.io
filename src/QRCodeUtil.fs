module QRCodeUtil

open QRCoder
open SkiaSharp
open System.IO

/// Width (in pixels) of generated QR code image
let WIDTH = 128

/// Height (in pixels) of generated QR code image
let HEIGHT = 128

let private convertByteArrayToImage (qrCodeAsPngByteArr: byte[]) =
    use ms = new MemoryStream(qrCodeAsPngByteArr)
    use skStream = new SKManagedStream(ms)
    let bitmap = SKBitmap.Decode(skStream)
    bitmap

let private resizeBitmap (bitmap: SKBitmap) = 
    // Resize the bitmap to the specified width and height
    let resizedBitmap = new SKBitmap(WIDTH, HEIGHT)
    use canvas = new SKCanvas(resizedBitmap)
    let paint = new SKPaint()
    paint.IsAntialias <- true
    paint.FilterQuality <- SKFilterQuality.High
    canvas.DrawBitmap(bitmap, SKRect.Create(0.0f, 0.0f, float32 WIDTH, float32 WIDTH), paint)
    resizedBitmap

let private saveBitmapToFile (bitmap: SKBitmap) (filePath: string) =
    use image = SKImage.FromBitmap(bitmap)
    use data = image.Encode(SKEncodedImageFormat.Png, 100)
    use stream = File.OpenWrite(filePath)
    data.SaveTo(stream)

let generateQRCode (text: string) (filePath: string) =
    let qrGenerator = new QRCodeGenerator()
    let qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q)
    let qrCode = new PngByteQRCode(qrCodeData)
    let qrCodeAsPngByteArr = qrCode.GetGraphic(20)

    // Convert byte array to image using SkiaSharp
    let bitmap = convertByteArrayToImage qrCodeAsPngByteArr
    
    let bitmap = resizeBitmap bitmap

    saveBitmapToFile bitmap filePath

