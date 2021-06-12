Public Class Calculadora
    Private Sub btnsuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuma.Click
        txtbx3.Text = Val(txtbx1.Text) + Val(txtbx2.Text)
    End Sub

    Private Sub btnResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResta.Click
        txtbx3.Text = Val(txtbx1.Text) - Val(txtbx2.Text)
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        txtbx3.Text = Val(txtbx1.Text) / Val(txtbx2.Text)
        If Val(txtbx1.Text) = 0 / Val(txtbx2.Text) = 0 Then
            txtbx3.Text = "ERROR"

        End If

    End Sub

    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
        txtbx3.Text = Val(txtbx1.Text) * Val(txtbx2.Text)
    End Sub

    Private Sub btnLimp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimp.Click
        txtbx1.Text = ""
        txtbx2.Text = ""
        txtbx3.Text = ""
    End Sub

    Private Sub btnSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSal.Click
        Close()
    End Sub
End Class
