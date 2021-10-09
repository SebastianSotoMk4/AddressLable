<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UserInputBox = New System.Windows.Forms.GroupBox()
        Me.DisplayBox = New System.Windows.Forms.GroupBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.NameLable = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayNameLable = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UserInputBox.SuspendLayout()
        Me.DisplayBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserInputBox
        '
        Me.UserInputBox.Controls.Add(Me.StateLabel)
        Me.UserInputBox.Controls.Add(Me.StateTextBox)
        Me.UserInputBox.Controls.Add(Me.ZipLabel)
        Me.UserInputBox.Controls.Add(Me.CityLabel)
        Me.UserInputBox.Controls.Add(Me.AddressLabel)
        Me.UserInputBox.Controls.Add(Me.NameLable)
        Me.UserInputBox.Controls.Add(Me.ZipTextBox)
        Me.UserInputBox.Controls.Add(Me.CityTextBox)
        Me.UserInputBox.Controls.Add(Me.AddressTextBox)
        Me.UserInputBox.Controls.Add(Me.NameTextBox)
        Me.UserInputBox.Location = New System.Drawing.Point(12, 12)
        Me.UserInputBox.Name = "UserInputBox"
        Me.UserInputBox.Size = New System.Drawing.Size(315, 426)
        Me.UserInputBox.TabIndex = 0
        Me.UserInputBox.TabStop = False
        Me.UserInputBox.Text = "User Input"
        '
        'DisplayBox
        '
        Me.DisplayBox.Controls.Add(Me.Label5)
        Me.DisplayBox.Controls.Add(Me.Label3)
        Me.DisplayBox.Controls.Add(Me.Label4)
        Me.DisplayBox.Controls.Add(Me.Label2)
        Me.DisplayBox.Controls.Add(Me.DisplayNameLable)
        Me.DisplayBox.Location = New System.Drawing.Point(427, 12)
        Me.DisplayBox.Name = "DisplayBox"
        Me.DisplayBox.Size = New System.Drawing.Size(361, 438)
        Me.DisplayBox.TabIndex = 1
        Me.DisplayBox.TabStop = False
        Me.DisplayBox.Text = "Address Display"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(24, 49)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(122, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(24, 96)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(122, 20)
        Me.AddressTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(24, 139)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(122, 20)
        Me.CityTextBox.TabIndex = 2
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(24, 179)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(122, 20)
        Me.ZipTextBox.TabIndex = 3
        '
        'NameLable
        '
        Me.NameLable.AutoSize = True
        Me.NameLable.Location = New System.Drawing.Point(21, 33)
        Me.NameLable.Name = "NameLable"
        Me.NameLable.Size = New System.Drawing.Size(86, 13)
        Me.NameLable.TabIndex = 4
        Me.NameLable.Text = "Name, First & Last"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(21, 80)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(54, 13)
        Me.AddressLabel.TabIndex = 5
        Me.AddressLabel.Text = "Address 1"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(21, 123)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 6
        Me.CityLabel.Text = "City"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(21, 163)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(84, 13)
        Me.ZipLabel.TabIndex = 7
        Me.ZipLabel.Text = "Zip/Postal Code"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(23, 202)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 9
        Me.StateLabel.Text = "State"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(26, 218)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(122, 20)
        Me.StateTextBox.TabIndex = 8
        '
        'DisplayNameLable
        '
        Me.DisplayNameLable.AutoSize = True
        Me.DisplayNameLable.Location = New System.Drawing.Point(21, 33)
        Me.DisplayNameLable.Name = "DisplayNameLable"
        Me.DisplayNameLable.Size = New System.Drawing.Size(95, 13)
        Me.DisplayNameLable.TabIndex = 10
        Me.DisplayNameLable.Text = "DisplayNameLable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Label5"
        '
        'AddressLable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplayBox)
        Me.Controls.Add(Me.UserInputBox)
        Me.Name = "AddressLable"
        Me.Text = "Form1"
        Me.UserInputBox.ResumeLayout(False)
        Me.UserInputBox.PerformLayout()
        Me.DisplayBox.ResumeLayout(False)
        Me.DisplayBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserInputBox As GroupBox
    Friend WithEvents DisplayBox As GroupBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents NameLable As Label
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DisplayNameLable As Label
End Class
