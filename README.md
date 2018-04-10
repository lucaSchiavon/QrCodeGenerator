# QrCodeGenerator
# pagina aspx :<asp:Image ID="Image1" runat="server" Style="border-width:0px;width:450px;height:450px" />

# codebehind (per inserire il qr code su pagina web essendo una bitmap va convertito in jpg mediante un MemoryStream)
# //inserisce il barcode
#         string Testo = UtentiExtend.Room.ToString() + "|" + UtentiExtend.IdentifierCode.ToString();
#         IBarcodeWriter GeneraBarcode = new BarcodeWriter() { Format = BarcodeFormat.QR_CODE };
#         Bitmap bitmapBarcode;
#         var risultato = GeneraBarcode.Write(Testo);
#         bitmapBarcode = new Bitmap(risultato);
#         System.IO.MemoryStream ms = new System.IO.MemoryStream();
# 
#         bitmapBarcode.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
#         byte[] byteImage = ms.ToArray();
#         var SigBase64 = Convert.ToBase64String(byteImage); //Get Base64
#         Image1.ImageUrl = "data:image/png;base64," + SigBase64;