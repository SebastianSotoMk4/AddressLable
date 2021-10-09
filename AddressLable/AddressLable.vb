'Sebastian Soto
'RCET0265
'Fall 2021
'Address Lable
'https://github.com/SebastianSotoMk4/AddressLable.git
Option Strict On
Option Explicit On
Public Class AddressLable
    Private Sub MakeLableButton_Click(sender As Object, e As EventArgs) Handles MakeLableButton.Click
        DisplayAddressLable.Text = AddressTextBox.Text
        DisplayNameLable.Text = NameTextBox.Text
        DisplayCityLable.Text = CityTextBox.Text + " " + StateTextBox.Text + " " + ZipTextBox.Text
    End Sub
End Class
