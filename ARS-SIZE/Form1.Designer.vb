<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_disconnect = New System.Windows.Forms.Button()
        Me.btn_Connect = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Port = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Server = New System.Windows.Forms.TextBox()
        Me.lst_Forms = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_getSize = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(12, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(840, 2)
        Me.Label18.TabIndex = 52
        '
        'btn_disconnect
        '
        Me.btn_disconnect.Enabled = False
        Me.btn_disconnect.Location = New System.Drawing.Point(777, 23)
        Me.btn_disconnect.Name = "btn_disconnect"
        Me.btn_disconnect.Size = New System.Drawing.Size(75, 20)
        Me.btn_disconnect.TabIndex = 51
        Me.btn_disconnect.Text = "Logout"
        Me.btn_disconnect.UseVisualStyleBackColor = True
        '
        'btn_Connect
        '
        Me.btn_Connect.Location = New System.Drawing.Point(696, 23)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Size = New System.Drawing.Size(75, 20)
        Me.btn_Connect.TabIndex = 50
        Me.btn_Connect.Text = "Login"
        Me.btn_Connect.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(492, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Password"
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(490, 23)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(200, 20)
        Me.txt_Password.TabIndex = 48
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(286, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Username"
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(284, 23)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(200, 20)
        Me.txt_Username.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(220, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Port"
        '
        'txt_Port
        '
        Me.txt_Port.Location = New System.Drawing.Point(218, 23)
        Me.txt_Port.Name = "txt_Port"
        Me.txt_Port.Size = New System.Drawing.Size(60, 20)
        Me.txt_Port.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Server"
        '
        'txt_Server
        '
        Me.txt_Server.Location = New System.Drawing.Point(12, 23)
        Me.txt_Server.Name = "txt_Server"
        Me.txt_Server.Size = New System.Drawing.Size(200, 20)
        Me.txt_Server.TabIndex = 42
        '
        'lst_Forms
        '
        Me.lst_Forms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lst_Forms.Location = New System.Drawing.Point(12, 72)
        Me.lst_Forms.Name = "lst_Forms"
        Me.lst_Forms.Size = New System.Drawing.Size(840, 366)
        Me.lst_Forms.TabIndex = 53
        Me.lst_Forms.UseCompatibleStateImageBehavior = False
        Me.lst_Forms.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Anzahl"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Größe"
        '
        'btn_getSize
        '
        Me.btn_getSize.Enabled = False
        Me.btn_getSize.Location = New System.Drawing.Point(760, 412)
        Me.btn_getSize.Name = "btn_getSize"
        Me.btn_getSize.Size = New System.Drawing.Size(92, 26)
        Me.btn_getSize.TabIndex = 54
        Me.btn_getSize.Text = "Do"
        Me.btn_getSize.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 450)
        Me.Controls.Add(Me.btn_getSize)
        Me.Controls.Add(Me.lst_Forms)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btn_disconnect)
        Me.Controls.Add(Me.btn_Connect)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_Port)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_Server)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "ARS-SIZE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents btn_disconnect As Button
    Friend WithEvents btn_Connect As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_Port As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_Server As TextBox
    Friend WithEvents lst_Forms As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btn_getSize As Button
End Class
