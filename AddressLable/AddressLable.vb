'Sebastian Soto
'RCET0265
'Fall 2021
'Address Lable
'https://github.com/SebastianSotoMk4/AddressLable.git
Option Strict On
Option Explicit On
Public Class AddressLable
    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged

    End Sub

    Private Sub ZipTextBox_TextChanged(sender As Object, e As EventArgs) Handles ZipTextBox.TextChanged

    End Sub

    Private Sub StateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged

    End Sub
    Private Sub MakeLableButton_Click(sender As Object, e As EventArgs) Handles MakeLableButton.Click
        DisplayAddressLable.Text = AddressTextBox.Text
        DisplayNameLable.Text = NameTextBox.Text
        DisplayCityLable.Text = CityTextBox.Text
        DisplayStateLable.Text = StateTextBox.Text
        DisplayZipLable.Text = ZipTextBox.Text


    End Sub
    Private Sub DisplayAddressLable_Click(sender As Object, e As EventArgs) Handles DisplayAddressLable.Click
        Me.Text = AddressTextBox.Text

    End Sub

    Private Sub DisplayNameLable_Click(sender As Object, e As EventArgs) Handles DisplayNameLable.Click
        Me.Text = NameTextBox.Text
    End Sub

    Private Sub DisplayCityLable_Click(sender As Object, e As EventArgs) Handles DisplayCityLable.Click
        Me.Text = CityTextBox.Text
    End Sub

    Private Sub DisplayZipLable_Click(sender As Object, e As EventArgs) Handles DisplayZipLable.Click
        Me.Text = ZipTextBox.Text
    End Sub

    Private Sub DisplayStateLable_Click(sender As Object, e As EventArgs) Handles DisplayStateLable.Click
        Me.Text = StateTextBox.Text
    End Sub

    Private Sub NameLable_Click(sender As Object, e As EventArgs) Handles NameLable.Click

    End Sub

    Private Sub AddressLabel_Click(sender As Object, e As EventArgs) Handles AddressLabel.Click

    End Sub

    Private Sub CityLabel_Click(sender As Object, e As EventArgs) Handles CityLabel.Click

    End Sub

    Private Sub ZipLabel_Click(sender As Object, e As EventArgs) Handles ZipLabel.Click

    End Sub

    Private Sub StateLabel_Click(sender As Object, e As EventArgs) Handles StateLabel.Click

    End Sub


End Class
'https://elearn.isu.edu/moodle/mod/assign/view.php?id=2180790