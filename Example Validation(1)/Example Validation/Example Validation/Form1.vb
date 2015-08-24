Public Class Form1

    Private Sub btnFindType_Click(sender As System.Object, e As System.EventArgs) Handles btnFindType.Click
        Dim strIntTemp As String = txtInput.Text
        Dim intTemp As Integer
        Dim intTemp2 As Integer
        Dim blnIsValid As Boolean = True

        Try
            If Not Integer.TryParse(strIntTemp, intTemp) Then
                blnIsValid = False
                MessageBox.Show("The first temperature is not valid")
                txtInput.Clear()
                txtInput.Focus()
            End If

            If Not Integer.TryParse(txtTemp2.Text, intTemp2) Then
                blnIsValid = False
                MessageBox.Show("The second temperature is not valid")
                txtTemp2.Clear()
                txtTemp2.Focus()
            End If


            If blnIsValid Then
                'perform procedure's operations
                MessageBox.Show("Both numbers were integers!")
            End If


        Catch ex As Exception

        End Try



    End Sub


End Class
