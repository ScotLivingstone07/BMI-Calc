Public Class Form1
    Dim dbl_Height As Double
    Dim dbl_Weight As Double
    Dim dbl_BMI As Double


    Private Sub txt_Height_TextChanged(sender As Object, e As EventArgs) Handles txt_Height.TextChanged
        If Not IsNumeric(txt_Height.Text) Then
            MessageBox.Show("Enter a value")
            txt_Height.Clear()
        End If
    End Sub

    Private Sub Txt_Weight_TextChanged(sender As Object, e As EventArgs) Handles Txt_Weight.TextChanged
        If Not IsNumeric(Txt_Weight.Text) Then
            MessageBox.Show("Enter a value")
            Txt_Weight.Clear()
        End If
    End Sub
    Private Sub moveToLabels()
        lbl_Height.Text = txt_Height.Text
        lbl_Weight.Text = Txt_Weight.Text

        txt_Height.Text = ""
        Txt_Weight.Text = ""

    End Sub
    Public Function GetNumeric(ByVal strValue As String) As Double
        Dim dblValue As Double = -1
        If IsNumeric(strValue) Then
            dblValue = CType(strValue, Double)
        End If
        Return dblValue
    End Function
    Public Function CalcBMI(ByVal height As Double, weight As Double)

        CalcBMI = Weight / (Height * Height)
    End Function
    Public Sub displayDiagnosis(ByVal BMI As Double)
        If (BMI >= 20) And (BMI <= 25) Then
            lbl_Info.Text = "Normal"
        Else
            If BMI > 25 Then
                lbl_Info.Text = "Over Weight"
            Else
                lbl_Info.Text = "Under Weight"
            End If
        End If
    End Sub

    Private Sub btn_CalcBMI_Click(sender As Object, e As EventArgs) Handles btn_CalcBMI.Click

        moveToLabels()
        dbl_Height = GetNumeric(lbl_Height.Text)
        dbl_Weight = GetNumeric(lbl_Weight.Text)
        If dbl_Weight = -1 Or dbl_Height = -1 Then
            Exit Sub
        End If
        dbl_BMI = CalcBMI(dbl_Height, dbl_Weight)
        lbl_Result.Text = CType(dbl_BMI, String)
        displayDiagnosis(dbl_BMI)

    End Sub
End Class
