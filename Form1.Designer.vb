Imports System.Drawing.Imaging
Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnCompress = New Button()
        lblFileName = New Label()
        ofdFile = New OpenFileDialog()
        imagePreview = New PictureBox()
        lblDateCreated = New Label()
        lblFileSize = New Label()
        titleSelect = New Label()
        lblHasil = New Label()
        CType(imagePreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCompress
        ' 
        btnCompress.BackColor = Color.White
        btnCompress.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnCompress.FlatStyle = FlatStyle.System
        btnCompress.ImageAlign = ContentAlignment.TopCenter
        btnCompress.Location = New Point(146, 442)
        btnCompress.Name = "btnCompress"
        btnCompress.Size = New Size(184, 46)
        btnCompress.TabIndex = 0
        btnCompress.Text = "Compress Image"
        btnCompress.UseVisualStyleBackColor = False
        ' 
        ' lblFileName
        ' 
        lblFileName.AutoSize = True
        lblFileName.Location = New Point(12, 9)
        lblFileName.Name = "lblFileName"
        lblFileName.Size = New Size(0, 25)
        lblFileName.TabIndex = 1
        ' 
        ' ofdFile
        ' 
        ofdFile.FileName = "ofdFile"
        ofdFile.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp"
        ' 
        ' imagePreview
        ' 
        imagePreview.BackgroundImageLayout = ImageLayout.None
        imagePreview.Image = CType(resources.GetObject("imagePreview.Image"), Image)
        imagePreview.Location = New Point(146, 92)
        imagePreview.Name = "imagePreview"
        imagePreview.Size = New Size(532, 331)
        imagePreview.SizeMode = PictureBoxSizeMode.Zoom
        imagePreview.TabIndex = 2
        imagePreview.TabStop = False
        ' 
        ' lblDateCreated
        ' 
        lblDateCreated.AutoSize = True
        lblDateCreated.Location = New Point(12, 47)
        lblDateCreated.Name = "lblDateCreated"
        lblDateCreated.Size = New Size(17, 25)
        lblDateCreated.TabIndex = 3
        lblDateCreated.Text = " "
        ' 
        ' lblFileSize
        ' 
        lblFileSize.AutoSize = True
        lblFileSize.Location = New Point(402, 433)
        lblFileSize.Name = "lblFileSize"
        lblFileSize.Size = New Size(17, 25)
        lblFileSize.TabIndex = 4
        lblFileSize.Text = " "
        ' 
        ' titleSelect
        ' 
        titleSelect.AutoSize = True
        titleSelect.BackColor = SystemColors.Control
        titleSelect.Enabled = False
        titleSelect.Location = New Point(298, 372)
        titleSelect.Name = "titleSelect"
        titleSelect.Size = New Size(182, 25)
        titleSelect.TabIndex = 5
        titleSelect.Text = "Silahkan Pilih Gambar"
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(402, 473)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(17, 25)
        lblHasil.TabIndex = 6
        lblHasil.Text = " "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 524)
        Controls.Add(lblHasil)
        Controls.Add(titleSelect)
        Controls.Add(lblFileSize)
        Controls.Add(lblDateCreated)
        Controls.Add(imagePreview)
        Controls.Add(lblFileName)
        Controls.Add(btnCompress)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Basic Compress Image"
        CType(imagePreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Friend WithEvents btnCompress As Button
    Friend WithEvents lblFileName As Label
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents imagePreview As PictureBox
    Friend WithEvents lblDateCreated As Label
    Friend WithEvents lblFileSize As Label
    Friend WithEvents titleSelect As Label
    Friend WithEvents lblHasil As Label
End Class
