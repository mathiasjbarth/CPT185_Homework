Public Class frmWebTraffic
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim AllNumbers As Double = 0
        Dim Current As Double = 0
        Dim Average As Double = 0

        lstbData.Items.Clear()
        lblAverageTime.Visible = False

        For thisthing As Double = 0 To 11
            lstbData.Items.Add(InputBox("Enter the amount of time visited."))
        Next

        For i As Integer = 0 To lstbData.Items.Count - 1
            AllNumbers += Val(lstbData.Items(i))
            Current += 1
        Next
        Average = AllNumbers / Current
        lblAverageTime.Text = Average.ToString
        lblAverageTime.Visible = True

    End Sub
End Class
