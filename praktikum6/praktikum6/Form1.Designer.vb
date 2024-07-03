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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Txtnim = New TextBox()
        Txtnama = New TextBox()
        Txtprodi = New TextBox()
        Btambah = New Button()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(138, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(138, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "NAMA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(138, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "PRODI"
        ' 
        ' Txtnim
        ' 
        Txtnim.Location = New Point(226, 19)
        Txtnim.Name = "Txtnim"
        Txtnim.Size = New Size(181, 23)
        Txtnim.TabIndex = 3
        ' 
        ' Txtnama
        ' 
        Txtnama.Location = New Point(226, 52)
        Txtnama.Name = "Txtnama"
        Txtnama.Size = New Size(251, 23)
        Txtnama.TabIndex = 4
        ' 
        ' Txtprodi
        ' 
        Txtprodi.Location = New Point(226, 83)
        Txtprodi.Name = "Txtprodi"
        Txtprodi.Size = New Size(251, 23)
        Txtprodi.TabIndex = 5
        ' 
        ' Btambah
        ' 
        Btambah.BackColor = SystemColors.ActiveCaption
        Btambah.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btambah.Location = New Point(138, 133)
        Btambah.Name = "Btambah"
        Btambah.Size = New Size(377, 37)
        Btambah.TabIndex = 6
        Btambah.Text = "Tambah"
        Btambah.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(138, 176)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(377, 143)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListView1)
        Controls.Add(Btambah)
        Controls.Add(Txtprodi)
        Controls.Add(Txtnama)
        Controls.Add(Txtnim)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Frmarraysatudimensi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtnim As TextBox
    Friend WithEvents Txtnama As TextBox
    Friend WithEvents Txtprodi As TextBox
    Friend WithEvents Btambah As Button
    Friend WithEvents ListView1 As ListView

End Class
