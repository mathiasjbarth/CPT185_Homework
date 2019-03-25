<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebTraffic
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
        Me.lstbData = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblAverageTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstbData
        '
        Me.lstbData.FormattingEnabled = True
        Me.lstbData.Location = New System.Drawing.Point(195, 80)
        Me.lstbData.Name = "lstbData"
        Me.lstbData.Size = New System.Drawing.Size(59, 225)
        Me.lstbData.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(42, 80)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(118, 23)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Enter Visitor Analytics"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(77, 27)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(131, 13)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Website Traffic Measuring"
        '
        'lblAverageTime
        '
        Me.lblAverageTime.AutoSize = True
        Me.lblAverageTime.Location = New System.Drawing.Point(60, 292)
        Me.lblAverageTime.Name = "lblAverageTime"
        Me.lblAverageTime.Size = New System.Drawing.Size(73, 13)
        Me.lblAverageTime.TabIndex = 3
        Me.lblAverageTime.Text = "Average Here"
        Me.lblAverageTime.Visible = False
        '
        'frmWebTraffic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 427)
        Me.Controls.Add(Me.lblAverageTime)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstbData)
        Me.Name = "frmWebTraffic"
        Me.Text = "Website Traffic Metrics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstbData As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblAverageTime As Label
End Class
