Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the program
        Me.Close()
    End Sub

    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        ' Display the translation for the latin word sinister
        lblEnglishTranslation.Text = "left"
        lblEnglishTranslation.TextAlign = ContentAlignment.MiddleLeft

    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        ' Display the translation for the latin word medium
        lblEnglishTranslation.Text = "center"
        lblEnglishTranslation.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        ' Display the Translation for the latin word dexter
        lblEnglishTranslation.Text = "right"
        lblEnglishTranslation.TextAlign = ContentAlignment.MiddleRight

    End Sub
End Class
