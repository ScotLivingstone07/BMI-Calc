<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_CalcBMI = New System.Windows.Forms.Button()
        Me.txt_Height = New System.Windows.Forms.TextBox()
        Me.Txt_Weight = New System.Windows.Forms.TextBox()
        Me.lbl_M = New System.Windows.Forms.Label()
        Me.lbl_Weight = New System.Windows.Forms.Label()
        Me.lbl_KG = New System.Windows.Forms.Label()
        Me.lbl_Height = New System.Windows.Forms.Label()
        Me.lbl_Diagnosis = New System.Windows.Forms.Label()
        Me.lbl_BMI = New System.Windows.Forms.Label()
        Me.lbl_Stone = New System.Windows.Forms.Label()
        Me.lbl_fOOT = New System.Windows.Forms.Label()
        Me.lbl_Info = New System.Windows.Forms.Label()
        Me.lbl_Result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_CalcBMI
        '
        Me.btn_CalcBMI.Location = New System.Drawing.Point(12, 143)
        Me.btn_CalcBMI.Name = "btn_CalcBMI"
        Me.btn_CalcBMI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_CalcBMI.Size = New System.Drawing.Size(96, 65)
        Me.btn_CalcBMI.TabIndex = 0
        Me.btn_CalcBMI.Text = "Calc BMI"
        Me.btn_CalcBMI.UseVisualStyleBackColor = True
        '
        'txt_Height
        '
        Me.txt_Height.Location = New System.Drawing.Point(100, 57)
        Me.txt_Height.Name = "txt_Height"
        Me.txt_Height.Size = New System.Drawing.Size(100, 20)
        Me.txt_Height.TabIndex = 1
        '
        'Txt_Weight
        '
        Me.Txt_Weight.Location = New System.Drawing.Point(334, 51)
        Me.Txt_Weight.Name = "Txt_Weight"
        Me.Txt_Weight.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Weight.TabIndex = 2
        '
        'lbl_M
        '
        Me.lbl_M.AutoSize = True
        Me.lbl_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_M.Location = New System.Drawing.Point(219, 58)
        Me.lbl_M.Name = "lbl_M"
        Me.lbl_M.Size = New System.Drawing.Size(19, 16)
        Me.lbl_M.TabIndex = 3
        Me.lbl_M.Text = "m"
        '
        'lbl_Weight
        '
        Me.lbl_Weight.AutoSize = True
        Me.lbl_Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Weight.Location = New System.Drawing.Point(331, 75)
        Me.lbl_Weight.Name = "lbl_Weight"
        Me.lbl_Weight.Size = New System.Drawing.Size(59, 20)
        Me.lbl_Weight.TabIndex = 4
        Me.lbl_Weight.Text = "Weight"
        '
        'lbl_KG
        '
        Me.lbl_KG.AutoSize = True
        Me.lbl_KG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_KG.Location = New System.Drawing.Point(440, 58)
        Me.lbl_KG.Name = "lbl_KG"
        Me.lbl_KG.Size = New System.Drawing.Size(24, 16)
        Me.lbl_KG.TabIndex = 5
        Me.lbl_KG.Text = "Kg"
        '
        'lbl_Height
        '
        Me.lbl_Height.AutoSize = True
        Me.lbl_Height.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Height.Location = New System.Drawing.Point(100, 80)
        Me.lbl_Height.Name = "lbl_Height"
        Me.lbl_Height.Size = New System.Drawing.Size(56, 20)
        Me.lbl_Height.TabIndex = 6
        Me.lbl_Height.Text = "Height"
        '
        'lbl_Diagnosis
        '
        Me.lbl_Diagnosis.AutoSize = True
        Me.lbl_Diagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Diagnosis.Location = New System.Drawing.Point(136, 270)
        Me.lbl_Diagnosis.Name = "lbl_Diagnosis"
        Me.lbl_Diagnosis.Size = New System.Drawing.Size(83, 20)
        Me.lbl_Diagnosis.TabIndex = 7
        Me.lbl_Diagnosis.Text = "Diagnosis:"
        '
        'lbl_BMI
        '
        Me.lbl_BMI.AutoSize = True
        Me.lbl_BMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BMI.Location = New System.Drawing.Point(158, 243)
        Me.lbl_BMI.Name = "lbl_BMI"
        Me.lbl_BMI.Size = New System.Drawing.Size(42, 20)
        Me.lbl_BMI.TabIndex = 8
        Me.lbl_BMI.Text = "BMI:"
        '
        'lbl_Stone
        '
        Me.lbl_Stone.AutoSize = True
        Me.lbl_Stone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stone.Location = New System.Drawing.Point(351, 322)
        Me.lbl_Stone.Name = "lbl_Stone"
        Me.lbl_Stone.Size = New System.Drawing.Size(130, 20)
        Me.lbl_Stone.TabIndex = 9
        Me.lbl_Stone.Text = "1 Stone = 6.35kg"
        '
        'lbl_fOOT
        '
        Me.lbl_fOOT.AutoSize = True
        Me.lbl_fOOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fOOT.Location = New System.Drawing.Point(351, 302)
        Me.lbl_fOOT.Name = "lbl_fOOT"
        Me.lbl_fOOT.Size = New System.Drawing.Size(107, 20)
        Me.lbl_fOOT.TabIndex = 10
        Me.lbl_fOOT.Text = "1 Foot = 0.3m"
        '
        'lbl_Info
        '
        Me.lbl_Info.AutoSize = True
        Me.lbl_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Info.Location = New System.Drawing.Point(219, 275)
        Me.lbl_Info.Name = "lbl_Info"
        Me.lbl_Info.Size = New System.Drawing.Size(29, 16)
        Me.lbl_Info.TabIndex = 11
        Me.lbl_Info.Text = "Info"
        '
        'lbl_Result
        '
        Me.lbl_Result.AutoSize = True
        Me.lbl_Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Result.Location = New System.Drawing.Point(219, 243)
        Me.lbl_Result.Name = "lbl_Result"
        Me.lbl_Result.Size = New System.Drawing.Size(46, 16)
        Me.lbl_Result.TabIndex = 12
        Me.lbl_Result.Text = "Result"
        Me.lbl_Result.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 351)
        Me.Controls.Add(Me.lbl_Result)
        Me.Controls.Add(Me.lbl_Info)
        Me.Controls.Add(Me.lbl_fOOT)
        Me.Controls.Add(Me.lbl_Stone)
        Me.Controls.Add(Me.lbl_BMI)
        Me.Controls.Add(Me.lbl_Diagnosis)
        Me.Controls.Add(Me.lbl_Height)
        Me.Controls.Add(Me.lbl_KG)
        Me.Controls.Add(Me.lbl_Weight)
        Me.Controls.Add(Me.lbl_M)
        Me.Controls.Add(Me.Txt_Weight)
        Me.Controls.Add(Me.txt_Height)
        Me.Controls.Add(Me.btn_CalcBMI)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_CalcBMI As Button
    Friend WithEvents txt_Height As TextBox
    Friend WithEvents Txt_Weight As TextBox
    Friend WithEvents lbl_M As Label
    Friend WithEvents lbl_Weight As Label
    Friend WithEvents lbl_KG As Label
    Friend WithEvents lbl_Height As Label
    Friend WithEvents lbl_Diagnosis As Label
    Friend WithEvents lbl_BMI As Label
    Friend WithEvents lbl_Stone As Label
    Friend WithEvents lbl_fOOT As Label
    Friend WithEvents lbl_Info As Label
    Friend WithEvents lbl_Result As Label
End Class
