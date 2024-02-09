Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckFile()
    End Sub

    Private Sub CheckFile()
        If String.IsNullOrEmpty(ofdFile.FileName) Or ofdFile.FileName Is "ofdFile" Then
            btnCompress.Visible = False
            titleSelect.Visible = True
        Else
            btnCompress.Visible = True
            titleSelect.Visible = False
        End If
    End Sub

    Private Sub PickImage()
        ' Membuka dialog untuk memilih file gambar

        If ofdFile.ShowDialog() = DialogResult.OK Then
            ' Menampilkan nama file yang dipilih pada label
            lblFileName.Text = $"Nama File : {ofdFile.SafeFileName}"

            Dim fileInfo As New FileInfo(ofdFile.FileName)
            Dim specificCulture As New CultureInfo("id-ID")
            Dim readableFormat As String = fileInfo.CreationTime.ToString("dddd, dd MMMM yyyy, HH:mm", specificCulture)

            lblDateCreated.Text = $"Tanggal Dibuat : {readableFormat}"

            ' Retrieve the size of the image file in bytes
            Dim fileSizeBytes As Long = fileInfo.Length

            ' Convert bytes to megabytes
            Dim readableSize As String = FormatFileSize(fileSizeBytes)
            lblFileSize.Text = $"Ukuran File: {readableSize}"

            Dim selectedImage As New Bitmap(ofdFile.FileName)
            imagePreview.Image = selectedImage

            CheckFile()
        End If
    End Sub

    Private Sub imagePreview_Click(sender As Object, e As EventArgs) Handles imagePreview.Click
        PickImage()
    End Sub

    Private Sub btnCompress_Click(sender As Object, e As EventArgs) Handles btnCompress.Click

        ' Memanggil procedure untuk melakukan kompresi gambar
        CompressImage(ofdFile.FileName)

    End Sub

    Private Sub CompressImage(ByVal filePath As String)
        Try
            ' Memuat gambar dari file yang dipilih
            Dim originalImage As New Bitmap(filePath)

            ' Menyiapkan parameter untuk kompresi gambar
            Dim encode As ImageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg)
            Dim encoderParams As New EncoderParameters(1)
            Dim qualityParam As New EncoderParameter(Encoder.Quality, 50L) ' Mengatur kualitas kompresi (0-100)
            encoderParams.Param(0) = qualityParam

            ' Menyimpan gambar yang sudah dikompresi
            Dim newFilePath As String = Path.Combine(Path.GetDirectoryName(filePath), "compressed_" + Path.GetFileName(filePath))
            originalImage.Save(newFilePath, encode, encoderParams)

            ' Menampilkan pesan bahwa kompresi berhasil
            Dim fileInfo As New FileInfo(newFilePath)
            Dim hasil As String = FormatFileSize(fileInfo.Length)
            lblHasil.Text = $"Compressed File : {hasil}"

            MessageBox.Show($"Kompresi gambar berhasil menjadi {hasil}. Gambar tersimpan di {newFilePath}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetEncoderInfo(ByVal format As ImageFormat) As ImageCodecInfo
        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()

        For Each codec As ImageCodecInfo In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next

        Return Nothing
    End Function

    Private Function FormatFileSize(ByVal fileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"Bytes", "KB", "MB", "GB", "TB", "PB", "EB"}
        Dim sizeType As Integer = 0
        Dim fileSize As Double = fileSizeBytes

        While fileSize >= 1024 And sizeType < sizeTypes.Length - 1
            fileSize /= 1024
            sizeType += 1
        End While

        Return String.Format("{0:0.##} {1}", fileSize, sizeTypes(sizeType))
    End Function
End Class
